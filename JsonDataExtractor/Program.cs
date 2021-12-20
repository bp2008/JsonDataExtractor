using BPUtil;
using BPUtil.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataExtractor
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			CertificateValidation.RegisterCallback(CertificateValidation.DoNotValidate_ValidationCallback);

			WindowsServiceInitOptions options = new WindowsServiceInitOptions();
			options.ServiceManagerButtons_UpdateSettingsFile = false;
			options.ServiceManagerButtons = new ButtonDefinition[]
			{
				new ButtonDefinition("Configure", onConfigure)
			};

			AppInit.WindowsService<JsonDataExtractor>(options);
		}

		private static void onConfigure(object sender, EventArgs e)
		{
			if (JsonDataExtractor.settings.collectors.Count == 0)
			{
				DataCollector example1 = new DataCollector();
				example1.url = "https://raw.githubusercontent.com/bp2008/JsonDataExtractor/main/example1.json";
				FileTemplate t1 = new FileTemplate();
				t1.Filename = "Example 1.txt";
				t1.Template = "{$.name} the {$.species} is {$.age} years old.";
				example1.fileTemplates.Add(t1);
				JsonDataExtractor.settings.collectors.Add(example1);

				DataCollector example2 = new DataCollector();
				example2.url = "https://raw.githubusercontent.com/bp2008/JsonDataExtractor/main/example2.json";
				FileTemplate t2 = new FileTemplate();
				t2.Filename = "Example 2.txt";
				t2.Template = "Name of element 0: {$.[0].name}\r\nName of element 1: {$.[1].name}\r\nName of element 2: {$.[2].name}\r\nName of element 3: {$.[3].name}\r\nName of element 4: {$.[4].name}\r\n\r\n(index 4 does not exist)\r\n\r\nGarfield's First Rival: {$.[?(@.name == 'Garfield')].rivals[0]}\r\n\r\nItems with rivals: {$.[?(@.rivals)].name}";
				example2.fileTemplates.Add(t2);
				JsonDataExtractor.settings.collectors.Add(example2);

				JsonDataExtractor.settings.Save();
			}
			MainConfiguration mc = new MainConfiguration();
			mc.ShowDialog();
		}
	}
}
