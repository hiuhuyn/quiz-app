using DAL.Services;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class TestBUS
    {
        private TestService _testService;

        public List<Test> ListTests { get; set; }
        public List<string> ListTopic {  get; set; }
        public Test Test { get; set; }
        public TestBUS()
        {
            _testService = new TestService();
        }
        public string GetAllTestByIdTeacher()
        {
            try
            {
                ListTests = _testService.GetAllTestByIdTeacher();
                if(ListTests != null) return "success";
                return "loading_fail";
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAll error: " + ex.Message);
                return ex.Message;
            }
        }

        public string GetTestById(string id)
        {
            if (id == null || id == "") return "id_empty";
            Test test = null;
            try
            {
                test = _testService.GetTestById(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            if (test == null) return "id_not_found";
            // tìm thấy test
            Test = test;
            return "succuss";
        }

        public string InsertTest(Test test)
        {
            if (test.TestName == null || test.TestName == "") return "name_is_empty";
            if (test.TimeLimit < 1) return "timelimit_is_less_1";
            try
            {
                Test newTest = _testService.InsertTest(test);
                if (newTest == null) throw new Exception("Lỗi không xác định");
                Test = newTest;
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateTest(Test test)
        {
            if (test.TestName == null || test.TestName == "") return "name_is_empty";
            if (test.TimeLimit < 1) return "timelimit_is_less_1";
            try
            {
                Test newTest = _testService.UpdateTest(test);
                if (newTest == null) throw new Exception("Lỗi không xác định");
                Test = newTest;
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteTest(string id)
        {
            if (id == null || id == "") return "id_is_empty";
            try
            {
                bool isDel = _testService.DeleteTest(id);
                if (isDel) return "succuss";
                return "delete_fail";
            }catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string GetListTopic()
        {
            try
            {
                ListTopic = _testService.GetListTopic();
                return "success";
            }catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
