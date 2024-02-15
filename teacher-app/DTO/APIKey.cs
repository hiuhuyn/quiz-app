using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class APIKey
    {
        public string Key { get; set; }
        public string ExpiredTime { get; set; }
        public APIKey(string key, string expiredTime)
        {
            Key = key;
            ExpiredTime = expiredTime;
        }
    }
}
