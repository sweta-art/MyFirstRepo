using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    public class Conditional
    {
        public string ParamType(int a)
        {
            if (a==0)
            {
                return "zero";
            }
            else if (a>0)
            {
                return "Positive";
            }
            else
            {
                return "negative";
            }
        }
        public string ParamTypeSwitch(int a)
        {

            return "";
        }
        public string evenOddNumber(int a)
        {
            string number = (a%2==0) ? "even" : "odd";
            return number;
        }
        public string Coalescing(string number)
        {
            string value = number??"Guest";
            return value;
        }
        public string nameofDays(int? a)
        {
            switch (a)
            {
                case 1:return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default: return "Wrong choice";
            }
        }
        
      
    }
}
