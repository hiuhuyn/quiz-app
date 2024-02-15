using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
