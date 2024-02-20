using DTO;

namespace DAL.Services
{
    public class LoginService
    {
        private const string UrlCheckLogin = "";
        private LoginService() { }
        public static APIKey CheckLoginByIdAndPassword(string id, string password)
        {

            APIKey aPIKey = new APIKey("hased_key_example", "170793182");

            return aPIKey;
        }
        public static bool CheckLoginByToken(string token)
        {

            return true;
        }
    }
}
