using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _16
    {

        public static int powerDigitSum(int exponent)
        {

            double result = Math.Pow(2, exponent);
            char[] splitedNumbers = result.ToString("N").Replace(',','0').Replace('.','0').ToCharArray();
            int sum = 0;
            foreach (char digit in splitedNumbers)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}
