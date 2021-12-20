using System.Collections.Generic;

namespace JsonDataExtractor
{
	public class DataCollector
	{
		public string url;
		public string user;
		public string pass;
		public long loadIntervalSeconds = 60;
		public List<FileTemplate> fileTemplates = new List<FileTemplate>();
		public override string ToString()
		{
			return string.IsNullOrWhiteSpace(url) ? "[URL not defined]" : url;
		}
	}
}