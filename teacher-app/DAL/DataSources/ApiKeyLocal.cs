using DTO;
using System;
using System.Xml;

namespace DAL.DataSources
{
    public class ApiKeyLocal
    {
        private string FileName
        {
            get
            {
                string initialPath = AppDomain.CurrentDomain.BaseDirectory;
                string newStr = initialPath.Replace("GUI\\bin\\Debug\\", "DAL\\DataSources\\ApiKey.xml");
                return newStr;
            }
            set { FileName = value; }
        }
        public static ApiKeyLocal Instance = new ApiKeyLocal();
        private XmlDocument doc;
        private XmlElement root;
        public string ApiKey { get; set; }
        private ApiKeyLocal()
        {
            doc = new XmlDocument();
            doc.Load(FileName);
            root = doc.DocumentElement;
        }

        public string Load()
        {
            if (ApiKey != null)
            {
                return ApiKey;
            }

            XmlNode key = root.SelectSingleNode("Key");
            if (key == null) return null;

            return key.InnerText;

        }
        public void SaveXml(string apiKey)
        {
            XmlNode Key = root.SelectSingleNode("Key");
            if (Key == null)
            {
                XmlElement key = doc.CreateElement("Key");
                key.InnerText = apiKey;
                root.AppendChild(key);
            }
            else
            {
                Key.InnerText = apiKey;
            }
            doc.Save(FileName);
        }

        public void RemoveXml()
        {
            XmlNode Key = root.SelectSingleNode("Key");
            if (Key == null) return;
            root.RemoveChild(Key);
            doc.Save(FileName);
        }
    }
}
