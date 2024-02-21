using DTO;
using System;
using System.Xml;

namespace DAL.DataSources
{
    public class TeacherLocal
    {
        private string FileName
        {
            get
            {
                string initialPath = AppDomain.CurrentDomain.BaseDirectory;
                string newStr = initialPath.Replace("GUI\\bin\\Debug\\", "DAL\\DataSources\\Teacher.xml");
                return newStr;
            }
            set { FileName = value; }
        }
        public Teacher Teacher { get; set; }
        public static TeacherLocal Instance = new TeacherLocal();
        private XmlDocument doc;
        private XmlElement root;
        private TeacherLocal()
        {
            doc = new XmlDocument();
            doc.Load(FileName);
            root = doc.DocumentElement;
        }

        public Teacher Load()
        {
            if(Teacher != null)
            {
                return Teacher;
            }
            XmlNode id = root.SelectSingleNode("ID");
            XmlNode name = root.SelectSingleNode("NAME");
            if (id == null || name == null) return null;
            return new Teacher(id.InnerText, name.InnerText);
        }
        public void SaveXml(Teacher teacher)
        {
            XmlNode id = root.SelectSingleNode("ID");
            XmlNode name = root.SelectSingleNode("NAME");
            if (id == null || name == null)
            {
                XmlElement idE = doc.CreateElement("ID");
                idE.InnerText = teacher.TeacherID;
                XmlElement nameE = doc.CreateElement("NAME");
                nameE.InnerText = teacher.TeacherName;
                root.AppendChild(idE);
                root.AppendChild(nameE);
            }
            else
            {
                id.InnerText = teacher.TeacherID;
                name.InnerText = teacher.TeacherName;
            }
            doc.Save(FileName);
        }

        public void RemoveXml()
        {
            XmlNode id = root.SelectSingleNode("ID");
            XmlNode name = root.SelectSingleNode("NAME");
            if (id == null || name == null) return;
            root.RemoveChild(id);
            root.RemoveChild(name);
            doc.Save(FileName);
        }
    }
}
