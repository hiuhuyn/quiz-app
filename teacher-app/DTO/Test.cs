using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Test
    {
        public string TestID { get; set; }
        public string TestName { get; set; }
        public string Topic {  get; set; }
        public string Creator { get; set; }
        public int TimeLimit { get; set; }
        public List<Question> QuestionList { get; set; }

        public Test(string testID, string testName, string topic, string creator, int timeLimit, List<Question> questionList)
        {
            TestID = testID;
            TestName = testName;
            Topic = topic;
            Creator = creator;
            TimeLimit = timeLimit;
            QuestionList = questionList;
        }
        public Test(string testName, string topic, string creator, int timeLimit, List<Question> questionList)
        {
            TestName = testName;
            Topic = topic;
            Creator = creator;
            TimeLimit = timeLimit;
            QuestionList = questionList;
        }
    }
}
