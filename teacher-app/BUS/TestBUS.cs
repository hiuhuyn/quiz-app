using DAL.Services;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class TestBUS
    {
        private TestService _testService;
        public TestBUS()
        {
            _testService = new TestService();
        }
        public List<Test> GetAllTestByIdTeacher()
        {

            return new List<Test>();
        }

        public Test GetTestById(string id)
        {
            if(id == null) return null;

            return null;
        }

        public string InsertTest(Test test)
        {

            return "";
        }
        public string UpdateTest(Test test)
        {
            return "";
        }

        public string DeleteTest(string id)
        {
            if (id == null) return null;

            return "";
        }
    }
}
