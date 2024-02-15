using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
