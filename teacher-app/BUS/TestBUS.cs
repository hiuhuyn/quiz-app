using DAL.DataSources;
using DAL.Services;
using DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUS
{
    public class TestBUS
    {
        private TestService _testService;

        public List<Test> ListTests { get; set; }
        public List<string> ListTopic { get; set; }
        public Test Test { get; set; }
        public TestBUS()
        {
            string apiKey = ApiKeyLocal.Instance.Load();
            _testService = new TestService(apiKey);
        }
        public string GetAllTestByIdTeacher()
        {
            try
            {
                Task<State<List<Test>>> state = Task.Run(() => _testService.GetAllTestByIdTeacher());

                State<List<Test>> result = state.Result;
                if (result.Value != null)
                {
                    ListTests = result.Value;
                    return "success";
                }
                else
                {
                    return result.ErrorContent.Message;
                }
            }
            catch (Exception ex)
            {
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

        public string CheckDataTest(Test test)
        {
            if (test.TestName == null || test.TestName == "") return "name_is_empty";
            if (test.TimeLimit < 1) return "timelimit_is_less_1";
            if (test.Topic == null || test.Topic == "") return "topic_empty";
            return "success";
        }


        public string InsertTest(Test test)
        {
            try
            {
                Task<State<Test>> state = Task.Run(() => _testService.InsertTest(test));
                State<Test> result = state.Result;
                if (result.Value != null)
                {
                    Test = result.Value;
                    return "success";
                }
                else
                {
                    return result.ErrorContent.Message;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateTest(Test test)
        {
            try
            {
                Task<State<Test>> state = Task.Run(() => _testService.UpdateTest(test));
                State<Test> result = state.Result;
                if (result.Value != null)
                {
                    Test = result.Value;
                    return "success";
                }
                else
                {
                    return result.ErrorContent.Message;
                }
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
                Task<State<bool>> state = Task.Run(() => _testService.DeleteTest(id));
                State<bool> result = state.Result;
                if (result.Value) return "success";
                return result.ErrorContent.Message;
            }
            catch (Exception ex)
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
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
