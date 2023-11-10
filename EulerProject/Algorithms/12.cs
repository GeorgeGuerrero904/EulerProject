using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _12
    {
        public static int divisibleTriangleNumber(int n)
        {
            int i = 1, result = 0;
            bool found = false;

            while (!found)
            {
                int triangleNumber = getTriangleNumber(i);
                if (getNumerOfDivisors(triangleNumber) >= n)
                {
                    result = triangleNumber;
                    found = true;
                }
                else i++;
            }
            return result;
        }
        private static int getTriangleNumber(int n)
        {
            return ((int)Math.Pow(n, 2) + n) / 2;
        }
        private static int getNumerOfDivisors(int n)
        {
            int count = 0;
            // Divisors come in pairs
            for (int i = 1; i < Math.Sqrt(n); i++)
                if (n % i == 0) count += 2;
            // Except for the sqrt
            if (n % Math.Sqrt(n) == 0) count += 1;

            return count;
        }
    }
}
