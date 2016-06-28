using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Collections;

namespace DMPlugin_TPJ
{
    public class Config
    {
        public Dictionary<string, string> configData;
        string fullFileName;
        public Config(string _fileName, bool fullname = false)
        {
            configData = new Dictionary<string, string>();
            if (fullname == false)
                fullFileName = AppDomain.CurrentDomain.BaseDirectory + @"\" + _fileName;
            else
                fullFileName = _fileName;
            bool hasCfgFile = File.Exists(fullFileName);
            if (hasCfgFile == false)
            {
                string dir = fullFileName.Substring(0, fullFileName.LastIndexOf(@"\"));
                if(!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                StreamWriter writer = new StreamWriter(File.Create(fullFileName), Encoding.Default);
                writer.Close();
            }
            StreamReader reader = new StreamReader(fullFileName, Encoding.Default);
            string line;
            int indx = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith(";") || string.IsNullOrEmpty(line))
                    configData.Add(";" + indx++, line);
                else
                {
                    string[] key_value = line.Split('=');
                    if (key_value.Length >= 2)
                        configData.Add(key_value[0], key_value[1]);
                    else
                        configData.Add(";" + indx++, line);
                }
            }
            reader.Close();
        }
        public string get(string key)
        {
            if (configData.Count <= 0)
                return null;
            else if (configData.ContainsKey(key))
                return configData[key].ToString();
            else
                return null;
        }

        public string get(string key, string default_value)
        {
            string ret = this.get(key);
            if (ret == null)
                return default_value;
            return ret;
        }
        public void set(string key, string value)
        {
            if (configData.ContainsKey(key))
                configData[key] = value;
            else
                configData.Add(key, value);
        }
        public void save()
        {
            StreamWriter writer = new StreamWriter(fullFileName, false, Encoding.Default);
            IDictionaryEnumerator enu = configData.GetEnumerator();
            while (enu.MoveNext())
            {
                if (enu.Key.ToString().StartsWith(";"))
                    writer.WriteLine(enu.Value);
                else
                    writer.WriteLine(enu.Key + "=" + enu.Value);
            }
            writer.Close();
        }
    }
}
