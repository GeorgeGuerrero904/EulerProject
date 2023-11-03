using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _1
    {

        //Find the sum of all the multiples of 3 or 5 below the provided parameter value number.
        public static long multiplesOf3and5(int num)
        {
            long sum = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            return sum;
        }
    }
}
