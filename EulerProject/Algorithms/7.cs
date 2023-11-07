using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _7
    {

        public static int nthPrime(int n)
        {
            int lastPrime = 1;
            for (int i = 1; i <= n; i++)
            {
                lastPrime = getNextPrime(lastPrime);
            }
            return lastPrime;
        }

        public static int getNextPrime(int start)
        {
            bool primeFound = false;
            while (!primeFound)
            {
                bool isDivisible = false;
                start++;
                for (int i = 2; i < start; i++)
                {
                    if (start % i == 0) isDivisible = true;
                }
                if (!isDivisible) primeFound = true;
            }
            return start;
        }
    }
}
