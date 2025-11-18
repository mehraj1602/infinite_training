using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment_17thnov_
{
    public static  class StringExtensions
    {
        public static bool IsUpper(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            return str == str.ToUpper();
        }
    }
    
   
}
