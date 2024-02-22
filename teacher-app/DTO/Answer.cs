using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DTO
{
    public class Answer
    {
        public bool IsCorrect { get; set; }
        public string AnswerContent { get; set; }

        public Answer(bool isCorrect, string answerContent)
        {
            IsCorrect = isCorrect;
            AnswerContent = answerContent;
        }
        public Answer(string xml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNode isCorrect = root.SelectSingleNode("IsCorrect");
            XmlNode content = root.SelectSingleNode("AnswerContent");
            IsCorrect = Convert.ToBoolean(isCorrect.InnerText);
            AnswerContent = content.InnerText;
        }
        public string ToXml()
        {
            return $@"<Answer>
                    <IsCorrect>{IsCorrect}</IsCorrect>
                    <AnswerContent>{AnswerContent}</AnswerContent>
                </Answer>";
        }
    }
}
