using BPUtil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JsonDataExtractor
{
	public class DataGrabber
	{
		private WebRequestUtility wru = new WebRequestUtility("JsonDataExtractor", 60000);

		public DataCollector definition;

		private Thread thrDataGrabber;

		private volatile bool abort = false;

		public event EventHandler<string> GotData = delegate { };
		/// <summary>
		/// Creates a DataGrabber that uses HTTP GET to download a string from a URL. The DataGrabber will be active until Stop() is called.
		/// </summary>
		/// <param name="url">Object defining the URL and other parameters for data collection.</param>
		public DataGrabber(DataCollector definition)
		{
			this.definition = definition;

			if (!string.IsNullOrWhiteSpace(definition.user) && definition.pass != null)
				wru.BasicAuthCredentials = new System.Net.NetworkCredential(definition.user, definition.pass);

			thrDataGrabber = new Thread(doWork);
			thrDataGrabber.Name = "DataGrabber " + definition.url;
			thrDataGrabber.IsBackground = true;
			thrDataGrabber.Start();
		}

		private void doWork()
		{
			try
			{
				Stopwatch sw = Stopwatch.StartNew();
				long intervalMs = definition.loadIntervalSeconds * 1000;
				while (!abort)
				{
					sw.Restart();
					try
					{
						BpWebResponse response = wru.GET(definition.url);
						if (response.StatusCode == 0)
						{
							Logger.Info("Request to \"" + definition.url + "\" failed to get a response.");
						}
						else if (response.StatusCode != 200)
						{
							string msg = "";
							Try.Swallow(() => msg = " " + response.str);
							Logger.Info("Request to \"" + definition.url + "\" failed with response status HTTP " + response.StatusCode + "." + msg);
						}
						else
						{
							// Success!
							GotData(this, response.str);
						}
					}
					catch (ThreadAbortException) { }
					catch (Exception ex)
					{
						Logger.Debug(ex, "DataGrabber error for URL: " + definition.url);
					}

					long timeLeftToWait = intervalMs - sw.ElapsedMilliseconds;
					while (!abort && timeLeftToWait > 0)
					{
						Thread.Sleep((int)Math.Min(timeLeftToWait, 1000));
						timeLeftToWait = intervalMs - sw.ElapsedMilliseconds;
					}
				}
			}
			catch (ThreadAbortException) { }
			catch (Exception ex)
			{
				Logger.Debug(ex, "DataGrabber is exiting early for URL: " + definition.url);
			}
		}

		public void Stop()
		{
			abort = true;
		}
	}
}
