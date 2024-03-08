using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1.Model
{
    [XmlRoot("TestList")]
    public class TestList
    {
        [XmlElement("Test")]
        public List<Test> Tests { get; set; }
    }

    public class Test
    {
        [XmlAttribute("TestID")]
        public string TestID { get; set; }

        [XmlAttribute("TeacherID")]
        public string TeacherID { get; set; }

        public string TestName { get; set; }
        public string Topic { get; set; }
        public int TimeLimit { get; set; }
        public QuestionList QuestionList { get; set; }

    }

    public class QuestionList
    {
        [XmlElement("Question")]
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public string QuestionContent { get; set; }

        [XmlElement("AnswerList")]
        public AnswerList Answers { get; set; }
    }

    public class AnswerList
    {
        [XmlElement("Answer")]
        public List<Answer> Answers { get; set; }
    }

    public class Answer
    {
        public bool IsCorrect { get; set; }
        public string AnswerContent { get; set; }
       
    }
}
