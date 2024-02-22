using DAL.DataSources;
using DAL.Services;
using DTO;
using DAL;
using System;
using System.Threading.Tasks;

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
                Task<State<string>> state = Task.Run(() => LoginService.CheckLoginByIdAndPassword(id, password));

                State<string> result = state.Result;
                if (result.Value != null)
                {
                    string aPIKey = result.Value;
                    if (aPIKey != null)
                    {
                        TeacherService teacherService = new TeacherService(aPIKey);
                        Task<State<Teacher>> stateTeacher = Task.Run(() => teacherService.GetInformation());
                        State<Teacher> resultTeacher = stateTeacher.Result;

                        if (resultTeacher.Value != null)
                        {
                            Teacher teacher = resultTeacher.Value;
                            if (isRememberLogin)
                            {
                                ApiKeyLocal.Instance.SaveXml(aPIKey);
                                TeacherLocal.Instance.SaveXml(teacher);
                            }
                            else
                            {
                                ApiKeyLocal.Instance.ApiKey = aPIKey;
                                TeacherLocal.Instance.Teacher = teacher;
                            }
                        }
                        else
                        {
                            return resultTeacher.ErrorContent.Message;
                        }
                        return "login_success";
                    }
                    else
                    {
                        return "Tài khoản không tồn tại";
                    }
                }
                else
                {
                    switch (result.ErrorContent.Message)
                    {
                        case "apikey_notfound":
                            return "404";
                        case "NotFound":
                            return "Không tìm thấy tài khoản";
                        default:
                            return result.ErrorContent.Message;
                    }
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
                string aPIKeyLocal = ApiKeyLocal.Instance.Load();
                if (aPIKeyLocal != null)
                {
                    return "login_success";
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


        }

        public static void Signout()
        {
            ApiKeyLocal.Instance.RemoveXml();
        }

    }
}
