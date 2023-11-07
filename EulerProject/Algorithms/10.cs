using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _10
    {
        public static long primeSummation(int limit)
        {
            long total = 0;
            int lastPrime = 2;
            while (lastPrime < limit)
            {
                total += lastPrime;
                lastPrime = _7.getNextPrime(lastPrime);
            }

            return total;
        }

    }
}
