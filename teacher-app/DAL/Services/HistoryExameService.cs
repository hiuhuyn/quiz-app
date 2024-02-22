using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL.Services
{
    public class HistoryExameService
    {
        private const string URL_Get = "";
        private string apiKey;
        public HistoryExameService(string apiKey) { this.apiKey = apiKey; }
        public async Task<State<List<Record>>> GetRecords(string testID)
        {
            List<Record> records = new List<Record>();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Constaints.GET_RECORDS_BY_ID_TEST(apiKey, testID));

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(responseBody);
                XmlNodeList nodes = doc.DocumentElement.ChildNodes;
                foreach (XmlNode item in nodes)
                {
                    records.Add(new Record(item.OuterXml));
                }
                return new State<List<Record>>(records);
            }
            else
            {
                return new State<List<Record>>(new Exception(response.StatusCode.ToString()));
            }
        }
    }
}
