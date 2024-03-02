using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class TeacherService
    {
        string apiKey;

        public TeacherService(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<State<Teacher>> GetInformation()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Constaints.GET_TEACHER_INFO(apiKey));

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Teacher teacher = new Teacher(responseBody);
                if (teacher.TeacherID != null && teacher.TeacherName != null)
                {
                    return new State<Teacher>(teacher);
                }
                else
                {
                    return new State<Teacher>(new Exception("Không tìm thấy dữ liệu"));
                }
            }
            else
            {
                return new State<Teacher>(new Exception($"Status code: {response.StatusCode}"));
            }

        }
        public void UpdatePassword(string password)
        {

        }

    }
}
