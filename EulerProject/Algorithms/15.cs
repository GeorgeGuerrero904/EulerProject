using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _15
    {

        public static BigInteger latticePaths(int gridSize)
        {
            //(2N)! / (N!)^2
            //Where N is the grid size
            BigInteger a = (Factorial(gridSize));
            return (Factorial(2 * gridSize)) / (a * a);
        }

        public static BigInteger Factorial(int f)
        {
            BigInteger total = 1;
            if (f == 0)
                return 1;
            else
                for (int i = 1; i <= f; i++)
                {
                    total *= i;
                }

            return total;
        }
    }
}
