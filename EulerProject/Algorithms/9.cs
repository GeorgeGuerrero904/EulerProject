using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _9
    {

        public static long specialPythagoreanTriplet(int n)
        {
            long sumOfabc = n;
            for (int a = 1; a < n; a++)
            {
                for (int b = a; b < n; b++)
                {
                    int c = n - a - b;
                    if (c > 0)
                    {
                        if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
                        {
                            sumOfabc = a * b * c;
                        }
                    }
                }
            }
            return sumOfabc;
        }
    }
}
