using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Constaints
    {
        public const string BASE_URL = "https://py-xmltest.onrender.com";
        public const string POST_TEACHER_LOGIN_URL = BASE_URL + "/auth/examinee-login";
        public static string GET_ALL_TEST(string apiKey)
        {
            return $"{BASE_URL}/test?api_key={apiKey}";
        }
        public static string POST_RECORDS(string apiKey)
        {
            return $"{BASE_URL}/record?api_key={apiKey}";
        }
    }
}
