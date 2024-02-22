using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DAL.Components;
using DAL.DataSources;
using DTO;
using static System.Net.Mime.MediaTypeNames;
namespace DAL.Services
{
    public class TestService
    {
        private string apiKey;

        public TestService(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<State<List<Test>>> GetAllTestByIdTeacher()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Constaints.GET_ALL_TEST(apiKey));

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(responseBody);
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.ChildNodes;
                List<Test> result = new List<Test>();

                foreach (XmlNode item in nodes)
                {
                    Test t = new Test(item.OuterXml);
                    result.Add(t);
                }
                return new State<List<Test>>(result);
            }
            else
            {
                return new State<List<Test>>(new Exception($"Status code: {response.StatusCode}"));
            }
        }

        public Test GetTestById(string id)
        {
            return DataFake.GetListTests.Find(item => item.TestID == id);
        }

        public async Task<State<Test>> InsertTest(Test test)
        {
            HttpClient client = new HttpClient();
            var content = new StringContent(test.ToXml(), Encoding.UTF8, "application/xml");
            HttpResponseMessage response = await client.PostAsync(Constaints.POST_ADD_NEW_TEST(apiKey), content);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Test t = new Test(result);
                return new State<Test>(t);
            }

            return new State<Test>(new Exception("Status code: " + response.StatusCode));

        }
        public async Task<State<Test>> UpdateTest(Test test)
        {
            HttpClient client = new HttpClient();
            var content = new StringContent(test.ToXml(), Encoding.UTF8, "application/xml");
            HttpResponseMessage response = await client.PutAsync(Constaints.PUT_UPDATE_TEST(apiKey, test.TestID), content);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Test t = new Test(result);
                return new State<Test>(t);
            }

            return new State<Test>(new Exception("Status code: " + response.StatusCode));
        }

        public async Task<State<bool>> DeleteTest(string id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync(Constaints.DEL_DELETE_TEST(apiKey, id));
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                XmlDocument document = new XmlDocument();
                document.LoadXml(result);
                XmlNode error = document.SelectSingleNode("Error");
                if (error != null)
                {
                    return new State<bool>(false, new Exception(error.InnerText));
                }
                return new State<bool>(true);
            }

            return new State<bool>(new Exception("Status code: " + response.StatusCode));
        }

        public List<string> GetListTopic()
        {
            List<string> list = new List<string>
            {
                "English",
                "Hóa",
                "Toán",
                "Đại số"
            };

            return list;
        }


    }
}
