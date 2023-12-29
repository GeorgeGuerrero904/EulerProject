using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _27
    {
        public static int quadraticPrimes(int range)
        {

            int winningProduct = 0, winningCount = 0;
            for (int b = 2; b <= range; b++)
            {
                // We only need to check a/b when b is prime
                if (!Util.primeUtil.isPrime(b))
                    continue;
                for (int a = -range + 1; a < range; a++)
                {
                    // a must have opposite parity of b
                    if ((b == 2 && a % 2 == 1) ||
                        (a % 2 == 0))
                        continue;
                    // Check count of primes from formula
                    int currentCount = countPrimes(a, b);
                    if (currentCount > winningCount)
                    {
                        winningProduct = a * b;
                        winningCount = currentCount;
                    }
                }
            }
            return winningProduct;
        }

        public static int countPrimes(int a, int b)
        {
            int output = b, n = 0, count = 0;
            while (Util.primeUtil.isPrime(output))
            {
                count++;
                n++;
                output = (n * n) + (a * n) + b;
            }
            return count;
        }
    }
}
