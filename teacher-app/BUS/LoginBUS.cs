using DAL.DataSources;
using DAL.Services;
using DTO;
using DAL;
using System;

namespace BUS
{
    public class LoginBUS
    {
        private LoginBUS() { }

        public static string CheckLoginByIdAndPassword(string id, string password, bool isRememberLogin)
        {
            if (id == "" || id == null) return "Bạn cần nhập tên tài khoản để đăng nhập";
            if (password == "" || password == null) return "Bạn chưa nhập mật khẩu";

            try
            {
                APIKey aPIKey = LoginService.CheckLoginByIdAndPassword(id, password);
                if (aPIKey != null)
                {
                    TeacherService teacherService = new TeacherService(aPIKey);
                    if (isRememberLogin)
                    {
                        ApiKeyLocal.Instance.SaveXml(aPIKey);
                        TeacherLocal.Instance.SaveXml(teacherService.GetInformation());
                    }
                    else
                    {
                        ApiKeyLocal.Instance.ApiKey = aPIKey;
                        TeacherLocal.Instance.Teacher = teacherService.GetInformation();

                    }
                    return "login_success";
                }
                else
                {
                    return "Tài khoản không tồn tại";
                }
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public static string CheckLoginByToken()
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
                return $"Error : {ex}";
            }
            return "login_success";

        }

        public static void Signout()
        {
            ApiKeyLocal.Instance.RemoveXml();
        }

    }
}
