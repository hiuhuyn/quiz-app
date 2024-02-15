using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Record
    {
        public string ExamineeID { get; set; }
        public string TestID { get; set; }
        public int Score { get; set; }
        public string SubmittedTime { get; set; }
        public Record(string examineeID, string testID, int score, string submittedTime)
        {
            ExamineeID = examineeID;
            TestID = testID;
            Score = score;
            SubmittedTime = submittedTime;
        }
    }
}
