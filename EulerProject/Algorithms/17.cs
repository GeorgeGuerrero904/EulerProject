using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _17
    {

        public static int numberLetterCounts(int limit)
        {
            int totalLetters = 0;
            for (int i = 1; i <= limit; i++)
            {
                string number = numberToLetters(i);
                totalLetters += number.Length;
            }
            return totalLetters;
        }

        public static string numberToLetters(int number)
        {
            string strNumber = "";
            string[] oneToNineteen = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number == 0)
            {
                strNumber = "zero";
            }
            else if (number < 20)
            {
                strNumber += oneToNineteen[number];
            }
            else if (number < 100)
            {
                strNumber += tens[number / 10];
                strNumber += oneToNineteen[number % 10];
            }
            else if (number < 1000 && number % 100 == 0)
            {
                strNumber += oneToNineteen[number / 100] + "Hundred";
            }
            else if (number < 1000)
            {
                strNumber += oneToNineteen[number / 100];
                strNumber += "hundredand";
                if (number % 100 < 20)
                {
                    strNumber += oneToNineteen[number % 100];
                }
                else
                {
                    strNumber += tens[(number % 100) / 10];
                    strNumber += oneToNineteen[number % 10];
                }

            }
            else if (number >= 1000)
            {
                strNumber = oneToNineteen[number / 1000] + "thousand";
            }
            return strNumber;
        }
    }
}
