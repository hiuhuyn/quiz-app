using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class APIKey
    {
        public  static string Key { get; set; }

        public APIKey(string key)
        {
            Key = key;
           
        }
        
    }
}

