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
                return HistoryExameService.GetRecords(testId);
            }catch (Exception ex)
            {
                return new List<Record>();
            }
        }
    }
}
