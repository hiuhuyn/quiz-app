using DAL.DataSources;
using DAL.Services;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HistoryExameBUS
    {
        public HistoryExameBUS() { }
        public List<Record> GetRecords(string testId)
        {
            try
            {
                string apikey = ApiKeyLocal.Instance.Load();
                if (apikey != null)
                {
                    HistoryExameService historyExameService = new HistoryExameService(apikey);
                    Task<State<List<Record>>> state = Task.Run(() => historyExameService.GetRecords(testId));
                    State<List<Record>> result = state.Result;
                    if (result.Value != null)
                    {
                        return result.Value.ToList();
                    }
                }
                return new List<Record>();
            }
            catch (Exception ex)
            {
                return new List<Record>();
            }
        }
    }
}
