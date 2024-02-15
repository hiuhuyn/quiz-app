using DTO;
using System.Xml;

namespace DAL.DataSources
{
    public class ApiKeyLocal
    {
        private const string FileName = "ApiKey.xml";
        public static ApiKeyLocal Instance = new ApiKeyLocal();
        private XmlDocument doc;
        private XmlElement root;
        public APIKey ApiKey { get; set; }
        private ApiKeyLocal()
        {
            doc = new XmlDocument();
            doc.Load(FileName);
            root = doc.DocumentElement;
        }

        public APIKey Load()
        {
            if (ApiKey != null)
            {
                return ApiKey;
            }
            string key = root.SelectSingleNode("Key").InnerText;
            string time = root.SelectSingleNode("ExpiredTime").InnerText;
            if (key == null || time == null) return null;

            return new APIKey(key, time);
        }
        public void SaveXml(APIKey apiKey)
        {
            XmlNode Key = root.SelectSingleNode("Key");
            XmlNode ExpiredTime = root.SelectSingleNode("ExpiredTime");
            if (Key == null && ExpiredTime == null)
            {
                XmlElement key = doc.CreateElement("Key");
                key.InnerText = apiKey.Key;
                XmlElement expiredTime = doc.CreateElement("ExpiredTime");
                expiredTime.InnerText = apiKey.ExpiredTime;
                root.AppendChild(key);
                root.AppendChild(expiredTime);
            }
            else
            {
                Key.InnerText = apiKey.Key;
                ExpiredTime.InnerText = apiKey.ExpiredTime;
            }
            doc.Save(FileName);
        }

        public void RemoveXml()
        {
            XmlNode Key = root.SelectSingleNode("Key");
            XmlNode ExpiredTime = root.SelectSingleNode("ExpiredTime");
            if (Key == null && ExpiredTime == null) return;
            root.RemoveChild(Key);
            root.RemoveChild(ExpiredTime);
            doc.Save(FileName);
        }
    }
}
