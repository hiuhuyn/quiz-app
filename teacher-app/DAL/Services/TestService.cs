using System;
using System.Collections.Generic;
using DAL.DataSources;
using DTO;
using static System.Net.Mime.MediaTypeNames;
namespace DAL.Services
{
    public class TestService
    {
        private const string URL_Get_AllTest = "";
        private const string URL_Insert_Test = "";
        private const string URL_Update_Test = "";
        private const string URL_Delete_Test = "";

        public TestService()
        {
        }

        public List<Test> GetAllTestByIdTeacher()
        {

            return DataFake.GetListTests;
        }

        public Test GetTestById(string id)
        {
            return DataFake.GetListTests.Find(item => item.TestID == id);
        }

        public Test InsertTest(Test test)
        {
            DataFake.GetListTests.Add(test);
            return test;
        }
        public Test UpdateTest(Test test)
        {
            int index = DataFake.GetListTests.FindIndex(item => item.TestID == test.TestID);
            if (index == -1) return null;
            DataFake.GetListTests[index] = test;
            return test;
        }

        public bool DeleteTest(string id)
        {
            int index = DataFake.GetListTests.FindIndex(item => item.TestID == id);
            if(index == -1)
            {
                return false;
            }
            DataFake.GetListTests.RemoveAt(index);
            return true;
        }

        public List<string> GetListTopic()
        {
            List<string> list = new List<string>
            {
                "English",
                "Hóa",
                "Toán",
                "Đại số"
            };

            return list;
        }


    }
}
