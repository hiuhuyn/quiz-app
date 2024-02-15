﻿using DAL.DataSources;
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
        public TeacherBUS()
        {
            APIKey apiKey = ApiKeyLocal.Instance.Load();
            if (apiKey != null)
            {
                teacherService = new TeacherService(apiKey);
            }
        }
        public Teacher GetTeacher()
        {

            if (teacherService == null)
            {
                return null;
            }
            else
            {
                return teacherService.GetInformation();
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