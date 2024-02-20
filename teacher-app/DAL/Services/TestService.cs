using System;
using System.Collections.Generic;
using DAL.DataSources;
using DTO;
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
            return DataFake.GetListTests[0];
        }

        public Test InsertTest(Test test)
        {

            return test;
        }
        public Test UpdateTest(Test test)
        {
            return test;
        }

        public bool DeleteTest(string id)
        {

            return true;
        }


    }
}
