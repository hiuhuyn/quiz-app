using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DTO
{
    public class Question
    {
        public string QuestionContent { get; set; }
        public List<Answer> AnswerList { get; set; }

        public Question(string questionContent, List<Answer> answerList)
        {
            QuestionContent = questionContent;
            AnswerList = answerList;
        }
        public Question(string xml)
        {
            AnswerList = new List<Answer>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNode content = root.SelectSingleNode("QuestionContent");
            XmlNodeList answersNote = root.SelectSingleNode("AnswerList").ChildNodes;

            QuestionContent = content?.InnerText;
            foreach(XmlNode item in answersNote)
            {
                Answer answer = new Answer(item.OuterXml);
                AnswerList.Add(answer);
            }
        }
        public string ToXml()
        {
            string answers = "";
            foreach(Answer a in AnswerList)
            {
                answers += a.ToXml();
            }

            string result = $@"<Question>
                <QuestionContent>{QuestionContent}</QuestionContent>
                <AnswerList>
                    {answers}
                </AnswerList>
            </Question>";
            return result;
        }
    }
}
