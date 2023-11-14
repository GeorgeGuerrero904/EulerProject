using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _13
    {

        public static long largeSum(string[] numbers)
        {
            BigInteger total = 0;
            foreach (string number in numbers)
            {
                total += BigInteger.Parse(number);
            }
            string sum = total.ToString();
            string res = sum.Replace('.', ' ').Replace(',', ' ').Substring(0, 10);

            return Convert.ToInt64(res);
        }
    }
}
