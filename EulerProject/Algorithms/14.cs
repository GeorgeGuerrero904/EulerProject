using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _14
    {
        public static int longestCollatzSequence(int limit)
        {
            int maxSteps = 0, maxValue = 0;
            for (int i = 0; i < limit; i++)
            {
                int result = testCollatzSequence(i);
                if (result > maxSteps)
                {
                    maxSteps = result;
                    maxValue = i;
                }
            }
            return maxValue;
        }

        public static int testCollatzSequence(int value)
        {
            int steps = 0;
            while (value > 1)
            {
                if (value % 2 == 0) value = value / 2;
                else value = (value * 3) + 1;
                steps++;
            }

            return steps;
        }
    }
}
