using BPUtil;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonDataExtractor
{
	public class FileTemplate
	{
		public string Filename;
		public string Template;
		public override string ToString()
		{
			return string.IsNullOrWhiteSpace(Filename) ? "[No filename]" : Filename;
		}
		/// <summary>
		/// Returns the result of applying the template to the specified JSON text.
		/// </summary>
		/// <param name="json">JSON text.</param>
		/// <returns></returns>
		public string ApplyTemplate(string json)
		{
			JObject jo = null;
			try
			{
				jo = JObject.Parse(json);
			}
			catch (Exception ex)
			{
			}
			JArray ja = null;
			try
			{
				ja = JArray.Parse(json);
			}
			catch (Exception ex)
			{
			}


			string t = Template;
			StringBuilder sb = new StringBuilder();
			StringBuilder jpathBuilder = new StringBuilder();
			bool IsInJPath = false;
			for (int i = 0; i < t.Length; i++)
			{
				char c = t[i];

				if (IsInJPath)
				{
					if (c == '}')
					{
						IsInJPath = false;
						string jpath = jpathBuilder.ToString();
						jpathBuilder.Clear();
						if (jpath.Length > 0)
						{
							if (jo != null)
							{
								try
								{
									List<JToken> tokens = Try.Get(() => jo.SelectTokens(jpath, false)).ToList();
									if (tokens == null || tokens.Count == 0)
										sb.Append("[?]");
									else
									{
										List<string> strs = tokens.Select(token => token.ToString()).ToList();
										sb.Append(string.Join(", ", strs));
									}
								}
								catch (Exception ex)
								{
									sb.Append("[x]");
								}
							}
							if (ja != null)
							{
								try
								{
									List<JToken> tokens = Try.Get(() => ja.SelectTokens(jpath, false)).ToList();
									if (tokens == null || tokens.Count == 0)
										sb.Append("[?]");
									else
									{
										List<string> strs = tokens.Select(token => token.ToString()).ToList();
										sb.Append(string.Join(", ", strs));
									}
								}
								catch (Exception ex)
								{
									sb.Append("[x]");
								}
							}
						}
						else
							sb.Append("[?]");
					}
					else
						jpathBuilder.Append(c);
				}
				else // !IsInJPath
				{
					if (c == '{')
						IsInJPath = true;
					else
						sb.Append(c);
				}
			}
			return sb.ToString();
		}
	}
}