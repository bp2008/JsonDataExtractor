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
	public partial class MainConfiguration : Form
	{
		public MainConfiguration()
		{
			InitializeComponent();

			RefreshListBox();
		}

		private void RefreshListBox()
		{
			lbUrls.ClearSelected();
			lbUrls.Items.Clear();
			lbUrls.BeginUpdate();
			foreach (DataCollector dc in JsonDataExtractor.settings.collectors)
				lbUrls.Items.Add(dc);
			lbUrls.EndUpdate();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			DataCollector dc = new DataCollector();
			JsonDataExtractor.settings.collectors.Add(dc);
			JsonDataExtractor.settings.Save();

			lbUrls.Items.Add(dc);
			lbUrls.SelectedIndex = lbUrls.Items.Count - 1;

			btnEdit_Click(sender, e);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			object selected = lbUrls.SelectedItem;
			if (selected != null && selected is DataCollector)
			{
				DataCollector item = (DataCollector)selected;

				DataCollectorEditor dce = new DataCollectorEditor(item);
				if (dce.ShowDialog() == DialogResult.OK)
				{
					item.url = dce.url;
					item.user = dce.username;
					item.pass = dce.password;
					item.fileTemplates = dce.fileTemplates;
					item.loadIntervalSeconds = dce.reloadSeconds;

					JsonDataExtractor.settings.Save();

					lbUrls.Items[lbUrls.SelectedIndex] = lbUrls.Items[lbUrls.SelectedIndex];
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			object selected = lbUrls.SelectedItem;
			if (selected != null && selected is DataCollector)
			{
				DataCollector item = (DataCollector)selected;

				JsonDataExtractor.settings.collectors.Remove(item);
				JsonDataExtractor.settings.Save();

				RefreshListBox();
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void lbUrls_DoubleClick(object sender, EventArgs e)
		{
			btnEdit_Click(sender, e);
		}
	}
}
