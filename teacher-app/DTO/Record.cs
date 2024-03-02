using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DTO
{
    public class Record
    {
        public string ExamineeID { get; set; }
        public string TestID { get; set; }
        public double Score { get; set; }
        public string SubmittedTime { get; set; }
        public Record(string examineeID, string testID, int score, string submittedTime)
        {
            ExamineeID = examineeID;
            TestID = testID;
            Score = score;
            SubmittedTime = submittedTime;
        }
        public Record(string xml)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            XmlElement root = xmlDocument.DocumentElement;
            string id = root.GetAttribute("ExamineeID");
            string testId = root.GetAttribute("TestID");
            XmlNode score = root.SelectSingleNode("Score");
            XmlNode submittedTime = root.SelectSingleNode("SubmittedTime");

            ExamineeID = id;
            TestID = testId;
            try
            {
                Score = Convert.ToDouble(score?.InnerText);
            }
            catch
            {
                Score = 0;
            }
            SubmittedTime = submittedTime?.InnerText;
        }
    }
}
