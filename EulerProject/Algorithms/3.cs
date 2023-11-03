using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _3
    {
        public static long largestPrimeFactor(long number)
        {
            long largestFactor = number;

            for (int i = 2; i <= Math.Sqrt(largestFactor); i++)
            {
                if (largestFactor % i == 0)
                {
                    long factor = largestFactor / i;
                    long candidate = largestPrimeFactor(factor);
                    return i > candidate ? i : candidate;
                }
            }
            return largestFactor;
        }
    }
}
