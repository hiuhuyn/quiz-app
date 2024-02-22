using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DTO
{
    public class Teacher
    {
        public string TeacherID { get; set; }
        public string TeacherPassword { get; set; }
        public string TeacherName { get; set; }
        public Teacher() { }
        public Teacher(string teacherID, string teacherName, string teacherPassword)
        {
            TeacherID = teacherID;
            TeacherName = teacherName;
            TeacherPassword = teacherPassword;
        }
        public Teacher(string teacherID, string teacherName)
        {
            TeacherID = teacherID;
            TeacherName = teacherName;
        }

        public Teacher(string strXML) : this()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(strXML);
            XmlElement root = xmlDoc.DocumentElement;
            string id = root.GetAttribute("TeacherID");
            XmlNode name = root.SelectSingleNode("TeacherName");
            XmlNode password = root.SelectSingleNode("TeacherPassword");

            if(id!=null) TeacherID=id;
            if (name != null) TeacherName = name.InnerText;
            if(password != null) TeacherPassword = password.InnerText;          
        }


    }
}
