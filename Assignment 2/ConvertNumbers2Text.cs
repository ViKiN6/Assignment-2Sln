using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class ConvertNumbers2Text
    {
        public static string convert(int input)
        {

            string[] singlesmap = { " ", "one", "two", "three", "four, 'five", "six", "seven", "eight", "nine", };
            string[] teensmap = { " ", "eleven", "twelve", "thirteen", "fourteen, 'fifteen", "sixteen", "seventeen", "eighteen", "nineteen", };
            string[] decademaps = { " ", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", };

            if (input == 0)
            {
                return "zero";
            }
            else if (input > 999 & input < 9999)
            {
                if (input % 1000 >= 100 && input % 1000 <= 19)
                {
                    return singlesmap[(input / 1000)] + "Thousand" + singlesmap[input / 1000 % 100] + "Hundred" + teensmap[input % 10];
                }
                return singlesmap[(input / 1000)] + "Thousands" + singlesmap[input / 100 % 10] + "Hundred" + teensmap[input % 100 / 10] + " " + singlesmap[input % 10];

            }
            else if (input > 99 & input < 9999)
            {
                if ((input % 1000 >= 100 && (input % 100 <= 19)))
                {
                    return singlesmap[(input / 1000)] + "Hundred" + teensmap[input % 100];
                }
                return singlesmap[input / 10] + "Hundred" + decademaps[input % 100 / 10] + "" + singlesmap[input % 10];

            }
              else if (input > 0 & input <= 90)
            {
                return decademaps[input / 10] + " " + singlesmap[input % 10];
            }
            else if (input > 10 & input < 20) 
            {
                return decademaps[input - 10];
            }
      else
            {
                return singlesmap[input];
            }
            return "";
        }
    }
}