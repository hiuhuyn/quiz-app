using DAL.DataSources;
using DAL.Services;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoginBUS
    {
        public LoginBUS() { }

        public string CheckLoginByIdAndPassword(string id, string password, bool isRememberLogin)
        {
            try
            {
                APIKey aPIKey = LoginService.CheckLoginByIdAndPassword(id, password);
                if (isRememberLogin)
                {
                    ApiKeyLocal.Instance.SaveXml(aPIKey);
                }
                else
                {
                    ApiKeyLocal.Instance.ApiKey = aPIKey;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return null;

        }

        public string CheckLoginByToken()
        {
            try
            {
                APIKey aPIKeyLocal = ApiKeyLocal.Instance.Load();
                if (aPIKeyLocal != null)
                {
                    bool isLoginSuccess = LoginService.CheckLoginByToken(aPIKeyLocal.Key);
                    if (!isLoginSuccess)
                    {
                        return "login_again";
                    }
                }
                else
                {
                    return "login_again";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return null;

        }

    }
}
