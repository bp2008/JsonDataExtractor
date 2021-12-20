using BPUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JsonDataExtractor
{
	public partial class JsonDataExtractor : ServiceBase
	{
		public static Configuration settings;

		private List<DataGrabber> grabbers = new List<DataGrabber>();
		public JsonDataExtractor()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			foreach (DataGrabber g in grabbers)
				g.Stop();
			grabbers.Clear();

			foreach (DataCollector c in settings.collectors)
			{
				DataGrabber g = new DataGrabber(c);
				g.GotData += GotData;
				grabbers.Add(g);
			}
		}

		private void GotData(object sender, string json)
		{
			DataGrabber g = (DataGrabber)sender;
			foreach (FileTemplate template in g.definition.fileTemplates)
			{
				try
				{
					string result = template.ApplyTemplate(json);
					Robust.Retry(() =>
					{
						if (!Directory.Exists(Globals.WritableDirectoryBase + "Files"))
							Directory.CreateDirectory(Globals.WritableDirectoryBase + "Files");
						File.WriteAllText(Globals.WritableDirectoryBase + "Files/" + template.Filename, result, ByteUtil.Utf8NoBOM);
					}
					, 5, 10, 15, 20, 25, 50, 125, 250, 500, 1000);
				}
				catch (Exception ex)
				{
					Logger.Debug(ex);
				}
			}
		}

		protected override void OnStop()
		{
			foreach (DataGrabber g in grabbers)
				g.Stop();
			grabbers.Clear();
		}
	}
}
