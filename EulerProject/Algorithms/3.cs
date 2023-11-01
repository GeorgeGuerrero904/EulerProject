using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    internal class _3
    {
        public static int largestPrimeFactor(int number)
        {
            int largestFactor = number;

            for (int i = 2; i <= Math.Sqrt(largestFactor); i++)
            {
                if (largestFactor % i == 0)
                {
                    int factor = largestFactor / i;
                    int candidate = largestPrimeFactor(factor);
                    return i > candidate ? i : candidate;
                }
            }
            return largestFactor;
        }
    }
}
