using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataSources
{
    internal class DataFake
    {

        public static List<Answer> GetAnswers = new List<Answer>
        {
            new Answer(false, "Đáp án 1"),
            new Answer(false, "Đáp án 2"),
            new Answer(true, "Đáp án 3"),
            new Answer(false, "Đáp án 4"),
        };
        public static List<Question> GetListQuestions = new List<Question>
        {
            new Question("Câu hỏi 2", new List<Answer>
            {
                new Answer(false, "Đáp án câu 2 ý 1"),
                new Answer(true, "Đáp án câu 2 ý 2"),
                new Answer(false, "Đáp án câu 2 ý 3"),
                new Answer(false, "Đáp án câu 2 ý 4"),
            }),
            new Question("Câu hỏi 3", new List<Answer>
            {
                new Answer(false, "Đáp án 3-1"),
                new Answer(false, "Đáp án 3-2"),
                new Answer(false, "Đáp án 3-3"),
                new Answer(true, "Đáp án 3-4"),
            }),
        };
        public static List<Test> GetListTests = new List<Test> {
            new Test("test_1", "Kiểm tra tiếng Anh 1", "English", "thuhoay19", 10, GetListQuestions),
            new Test("test_2", "Kiểm tra Hóa học 2", "Hóa", "thuhoay19", 9, GetListQuestions),
            new Test("test_3", "Kiểm tra 15p hóa", "Hóa", "thuhoay19", 9, GetListQuestions),
            new Test("test_4", "Kiểm tra 1 tiết Toán", "Hóa", "thuhoay19", 9, GetListQuestions),
            new Test("test_5", "Kiểm tra hệ số 1", "Hóa", "thuhoay19", 9, GetListQuestions),
            new Test("test_6", "Kiểm tra 15p KTPM-29b", "Hóa", "thuhoay19", 9, GetListQuestions),
        };
    }
}
