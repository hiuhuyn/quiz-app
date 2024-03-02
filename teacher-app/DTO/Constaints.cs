using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Constaints
    {
        public const string BASE_URL = "https://py-xmltest.onrender.com";
        public const string POST_TEACHER_LOGIN_URL = BASE_URL + "/auth/teacher-login";
        public static string GET_TEACHER_INFO(string apiKey)
        {
            return $"{BASE_URL}/teacher?api_key={apiKey}";
        }
        public static string GET_ALL_TEST(string apiKey)
        {
            return $"{BASE_URL}/test?api_key={apiKey}";
        }
        public static string POST_ADD_NEW_TEST(string apiKey)
        {
            return $"{BASE_URL}/test?api_key={apiKey}";
        }
        public static string PUT_UPDATE_TEST(string apiKey, string testId)
        {
            return $"{BASE_URL}/test?api_key={apiKey}&test_id={testId}";
        }
        public static string DEL_DELETE_TEST(string apiKey, string testId)
        {
            return $"{BASE_URL}/test?api_key={apiKey}&test_id={testId}";
        }
        public static string GET_RECORDS_BY_ID_TEST(string apiKey, string testId)
        {
            return $"{BASE_URL}/record?api_key={apiKey}&test_id={testId}";
        }
    }
}
