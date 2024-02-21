using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class TeacherService
    {
        private const string URL_GET_TEACHER = "";
        private const string URL_UPDATE_TEACHER = "";
        APIKey apiKey;

        public TeacherService(APIKey apiKey)
        {
            this.apiKey = apiKey;
        }

        public Teacher GetInformation()
        {
            return new Teacher("2011", "Minh Quân", "2911", apiKey);
        }
        public void UpdatePassword(string password)
        {

        }

    }
}
