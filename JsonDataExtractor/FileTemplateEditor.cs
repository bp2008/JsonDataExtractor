using BPUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDataExtractor
{
	public partial class FileTemplateEditor : Form
	{
		/// <summary>
		/// Gets or sets the file name.
		/// </summary>
		public string Filename
		{
			get
			{
				return txtFilename.Text;
			}
			set
			{
				txtFilename.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the template text.
		/// </summary>
		public string Template
		{
			get
			{
				return txtTemplate.Text.Replace("\r\n","\n").Replace('\r','\n').Replace("\n", "\r\n");
			}
			set
			{
				txtTemplate.Text = value.Replace("\r\n", "\n").Replace('\r', '\n').Replace("\n", "\r\n");
			}
		}

		/// <summary>
		/// The URL to load JSON data from.
		/// </summary>
		public string url;
		/// <summary>
		/// User name to load JSON data with.
		/// </summary>
		public string username;
		/// <summary>
		/// Password to load JSON data with.
		/// </summary>
		public string password;

		/// <summary>
		/// Json text that was loaded from the URL.
		/// </summary>
		private string Json;
		/// <summary>
		/// Error from loading JSON text from the URL.
		/// </summary>
		private string JsonError;

		public FileTemplateEditor()
		{
			InitializeComponent();
		}

		private void FileTemplateEditor_Load(object sender, EventArgs e)
		{
			btnLoadJson_Click(sender, e);
		}

		private void txtTemplate_TextChanged(object sender, EventArgs e)
		{
			UpdatePreview();
		}

		private void UpdatePreview()
		{
			if (txtPreview.InvokeRequired)
				txtPreview.Invoke((Action)UpdatePreview);
			else
			{
				if (!string.IsNullOrWhiteSpace(JsonError))
				{
					txtPreview.Text = "Not Available";
				}
				else
				{
					if (Json == null)
						txtPreview.Text = "Loading…";
					else
					{
						FileTemplate fileTemplate = new FileTemplate();
						fileTemplate.Filename = Filename;
						fileTemplate.Template = Template;
						txtPreview.Text = fileTemplate.ApplyTemplate(Json);
					}
				}
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void btnLoadJson_Click(object sender, EventArgs e)
		{
			Json = JsonError = null;
			if (string.IsNullOrWhiteSpace(url))
			{
				JsonError = "No URL was specified in the previous panel. Cannot preview.";
				UpdatePreview();
			}
			else
			{
				txtJson.Text = "Loading…";
				UpdatePreview();
				btnLoadJson.Enabled = false;
				SetTimeout.OnBackground(() =>
				{
					WebRequestUtility wru = new WebRequestUtility("JsonDataExtractor", 60000);
					if (!string.IsNullOrWhiteSpace(username) && password != null)
						wru.BasicAuthCredentials = new System.Net.NetworkCredential(username, password);

					BpWebResponse response = wru.GET(url);

					if (response.StatusCode == 0)
					{
						JsonError = "Request for Json data failed to get a response.";
					}
					else if (response.StatusCode != 200)
					{
						string msg = "";
						Try.Swallow(() => msg = " " + response.str);
						JsonError = "Request for Json data failed with response status HTTP " + response.StatusCode + "." + msg;
					}
					else
					{
						// Success!
						Json = response.str;
					}
					SetTimeout.OnGui(() =>
					{
						if (Json == null)
							txtJson.Text = JsonError;
						else
							txtJson.Text = Json.Replace("\r\n", "\n").Replace('\r', '\n').Replace("\n", "\r\n");
						btnLoadJson.Enabled = true;
					}, 0, this);
					UpdatePreview();
				}
				, 0
				, ex =>
				{
					JsonError = "An error occurred when trying to load JSON from the URL. " + ex.ToString();
					SetTimeout.OnGui(() =>
					{
						btnLoadJson.Enabled = true;
					}, 0, this);
					UpdatePreview();
				});
			}
			UpdatePreview();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			if (!File.Exists(Globals.ApplicationDirectoryBase + "TemplateSyntaxGuide.html"))
				MessageBox.Show("TemplateSyntaxGuide.html was not found in the application directory.");
			else
				Process.Start(Globals.ApplicationDirectoryBase + "TemplateSyntaxGuide.html");
		}
	}
}
