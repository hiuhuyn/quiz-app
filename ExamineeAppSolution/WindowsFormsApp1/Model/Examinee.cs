using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class Examinee
    {
        public static string ExamineeID { get; set; }
        

        public Examinee(string examineeID)
        {
            ExamineeID = examineeID;
            
        }

    }
    
}

