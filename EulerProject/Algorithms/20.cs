using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _20
    {
        public static int sumFactorialDigits(int n)
        {
            BigInteger factorialResult = 1;
            int total = 0;
            for (int i = n; i >= 1; i--)
            {
                factorialResult *= i;
            }
            char[] intLetters = factorialResult.ToString().ToCharArray();
            foreach (char c in intLetters)
            {
                total += (int)char.GetNumericValue(c);
            }

            return total;
        }
    }
}
