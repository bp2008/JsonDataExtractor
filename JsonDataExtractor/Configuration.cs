using BPUtil;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataExtractor
{
	public class Configuration : SerializableObjectBase
	{
		public List<DataCollector> collectors = new List<DataCollector>();
	}
}
