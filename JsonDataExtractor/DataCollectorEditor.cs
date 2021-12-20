using BPUtil;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDataExtractor
{
	public partial class DataCollectorEditor : Form
	{
		/// <summary>
		/// Gets the URL that is set in the form.
		/// </summary>
		public string url
		{
			get { return txtUrl.Text; }
		}
		/// <summary>
		/// Gets the user name that is set in the form.
		/// </summary>
		public string username
		{
			get { return txtUser.Text; }
		}
		/// <summary>
		/// Gets the password that is set in the form.
		/// </summary>
		public string password
		{
			get { return txtPass.Text; }
		}
		/// <summary>
		/// Gets the number of seconds to wait between data reloads from the URL.
		/// </summary>
		public long reloadSeconds
		{
			get { return (long)nudReloadSeconds.Value; }
		}
		/// <summary>
		/// The collection of file templates that are set in the form.
		/// </summary>
		public List<FileTemplate> fileTemplates;
		public DataCollectorEditor(DataCollector dc)
		{
			InitializeComponent();
			txtUrl.Text = dc.url;
			txtUser.Text = dc.user;
			txtPass.Text = dc.pass;
			nudReloadSeconds.Value = dc.loadIntervalSeconds;
			fileTemplates = JsonConvert.DeserializeObject<List<FileTemplate>>(JsonConvert.SerializeObject(dc.fileTemplates));

			RefreshListBox();
		}

		private void RefreshListBox()
		{
			lbFileTemplates.ClearSelected();
			lbFileTemplates.Items.Clear();
			lbFileTemplates.BeginUpdate();
			foreach (FileTemplate t in fileTemplates)
				lbFileTemplates.Items.Add(t);
			lbFileTemplates.EndUpdate();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FileTemplate t = new FileTemplate();
			t.Filename = "New File.txt";
			t.Template = "";
			fileTemplates.Add(t);

			RefreshListBox();
			lbFileTemplates.SelectedIndex = lbFileTemplates.Items.Count - 1;
			btnEdit_Click(sender, e);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			object selected = lbFileTemplates.SelectedItem;
			if (selected != null && selected is FileTemplate)
			{
				FileTemplate t = (FileTemplate)selected;

				FileTemplateEditor fte = new FileTemplateEditor();
				fte.Filename = t.Filename;
				fte.Template = t.Template;
				fte.url = txtUrl.Text;
				fte.username = txtUser.Text;
				fte.password = txtPass.Text;
				if (fte.ShowDialog() == DialogResult.OK)
				{
					t.Filename = fte.Filename.Trim();
					t.Template = fte.Template;

					lbFileTemplates.Items[lbFileTemplates.SelectedIndex] = lbFileTemplates.Items[lbFileTemplates.SelectedIndex];
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			object selected = lbFileTemplates.SelectedItem;
			if (selected != null && selected is FileTemplate)
			{
				FileTemplate t = (FileTemplate)selected;

				fileTemplates.Remove(t);

				RefreshListBox();
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

		private void lbFileTemplates_DoubleClick(object sender, EventArgs e)
		{
			btnEdit_Click(sender, e);
		}
	}
}
