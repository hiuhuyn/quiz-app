using DTO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlTypes;
using System.Xml.Linq;
using DAL.Components;

namespace DAL.Services
{
    public class LoginService
    {
        private LoginService() { }
        public static async Task<State<string>> CheckLoginByIdAndPassword(string id, string password)
        {

            string xmlData = $@"<Teacher>
                <TeacherID>{id}</TeacherID>
                <TeacherPassword>{password}</TeacherPassword>
            </Teacher>";

            HttpClient client = new HttpClient();
            var content = new StringContent(xmlData, Encoding.UTF8, "application/xml");

            // Thực hiện yêu cầu POST
            HttpResponseMessage response = await client.PostAsync(Constaints.POST_TEACHER_LOGIN_URL, content);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                XDocument xmlDoc = XDocument.Parse(responseBody);
                XElement key = xmlDoc.Root?.Element("Key");
                if (key != null)
                {
                    return new State<string>(key.Value);
                }
                else
                {
                    return new State<string>(new Exception("apikey_notfound"));
                }
            }
            else
            {
                return new State<string>(new Exception(response.StatusCode.ToString()));
            }
        }
    }
}
