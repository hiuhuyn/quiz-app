using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Examinee
    {
        public string ExamineeID { get; set; }
        public string ExamineeName { get; set; }
        public string ExamineePassword { get; set; }
        public APIKey APIKey { get; set; }
        public List<string> AvailableTest { get; set; }

        public Examinee(string examineeID, string examineeName, string examineePassword, APIKey aPIKey, List<string> availableTest)
        {
            ExamineeID = examineeID;
            ExamineeName = examineeName;
            ExamineePassword = examineePassword;
            APIKey = aPIKey;
            AvailableTest = availableTest;
        }
    }
}
