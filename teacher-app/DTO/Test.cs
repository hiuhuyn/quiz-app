using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DTO
{
    public class Test
    {
        public string TestID { get; set; }
        public string TestName { get; set; }
        public string Topic { get; set; }
        public string TeacherID { get; set; } // TeacherID
        public int TimeLimit { get; set; }
        public List<Question> QuestionList { get; set; }

        public Test() { }
        public Test(string testID, string testName, string topic, string teacherId, int timeLimit, List<Question> questionList)
        {
            TestID = testID;
            TestName = testName;
            Topic = topic;
            TeacherID = teacherId;
            TimeLimit = timeLimit;
            QuestionList = questionList;
        }

        public Test(string xml)
        {
            QuestionList = new List<Question>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            XmlElement root = xmlDoc.DocumentElement;

            string id = root.GetAttribute("TestID");
            string teacherID = root.GetAttribute("TeacherID");
            XmlNode name = root.SelectSingleNode("TestName");
            XmlNode topic = root.SelectSingleNode("Topic");
            XmlNode timeLimit = root.SelectSingleNode("TimeLimit");
            XmlNodeList questionListNode = root.SelectSingleNode("QuestionList").ChildNodes;

            TestID = id;
            TeacherID = teacherID;
            TestName = name?.InnerText;
            Topic = topic?.InnerText;
            TimeLimit = Convert.ToInt32(timeLimit?.InnerText);

            foreach (XmlNode item in questionListNode)
            {
                Question question = new Question(item.OuterXml);
                QuestionList.Add(question);
            }
        }
        public string ToXml()
        {
            string questons = "";
            foreach (Question item in QuestionList)
            {
                questons += item.ToXml();
            }
            string result = $@"<Test TestID=""{TestID}"" TeacherID=""{TeacherID}"">
                <TestName>{TestName}</TestName>
                <Topic>{Topic}</Topic>
                <TimeLimit>{TimeLimit}</TimeLimit>
                <QuestionList>{questons}</QuestionList>
            </Test>";
            return result;
        }
    }
}
