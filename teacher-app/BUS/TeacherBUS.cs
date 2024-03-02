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
    public class TeacherBUS
    {
        private TeacherService teacherService;
        public Teacher Teacher { get; set; }
        public TeacherBUS() { }
        public void InitOnline()
        {
            string apiKey = ApiKeyLocal.Instance.Load();
            if (apiKey != null)
            {
                teacherService = new TeacherService(apiKey);
            }
        }
        public string GetTeacherOnline()
        {

            if (teacherService == null)
            {
                return null;
            }
            else
            {
                Task<State<Teacher>> state = Task.Run(() => teacherService.GetInformation());
                State<Teacher> result = state.Result;

                if(result.Value!= null)
                {
                    Teacher = result.Value;
                    return "success";
                }
                else
                {
                    return result.ErrorContent.Message;
                }
                
            }
        }
        public string GetTeacherOffline()
        {

            if (teacherService == null)
            {
                return "fail";
            }
            else
            {
                Teacher = TeacherLocal.Instance.Load();
                return "success";
            }
        }
        public string UpdatePassword(string newPassword)
        {
            if (teacherService == null)
            {
                return null;
            }
            else
            {
                if (newPassword == null)
                {
                    return "is_empty";
                }
                if (newPassword.Length < 6)
                {
                    return "length_less_than_6";
                }
                try
                {
                    teacherService.UpdatePassword(newPassword);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                return "success";
            }
        }
    }
}
