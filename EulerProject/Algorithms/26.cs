using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using EulerProject.Util;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _26
    {
        public static int reciprocalCycles(int n)
        {
            int maxNum = 0, cycleN = 0;

            for (int i = 10; i < n; i++)
            {
                if (primeUtil.isPrime(i))
                {
                    int cLen = cycleLength(i);
                    if (cLen > cycleN)
                    {
                        cycleN = cLen;
                        maxNum = i;
                    }
                }

            }

            return maxNum;
        }

        public static int cycleLength(int n)
        {
            int k = 1, mod = 10 % n;
            while (mod != 1)
            {
                mod = (mod * 10) % n;
                k++;
            };
            return k;
        }
    }
}
