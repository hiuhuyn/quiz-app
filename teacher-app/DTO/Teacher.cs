using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teacher
    {
        public string TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherPassword { get; set; }
        public APIKey APIKey { get; set; }
        public Teacher() { }
        public Teacher(string teacherID, string teacherName, string teacherPassword, APIKey aPIKey)
        {
            TeacherID = teacherID;
            TeacherName = teacherName;
            TeacherPassword = teacherPassword;
            APIKey = aPIKey;
        }
        public Teacher(string teacherID, string teacherName)
        {
            TeacherID = teacherID;
            TeacherName = teacherName;
        }
    }
}
