using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _21
    {

        public static int sumAmicableNum(int n)
        {
            int total = 0;
            for (int i = 10; i < n; i++)
            {
                if (isAmicable(i))
                {
                    total += i;
                }
            }
            return total;
        }

        public static bool isAmicable(int a)
        {
            int b = sumProperDivisors(a);
            if (sumProperDivisors(b) == a && b != a) return true;
            else return false;
        }

        public static int sumProperDivisors(int n)
        {
            int total = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) total += i;
            }
            return total;
        }
    }
}
