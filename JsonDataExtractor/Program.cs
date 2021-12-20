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
			MainConfiguration mc = new MainConfiguration();
			mc.ShowDialog();
		}
	}
}
