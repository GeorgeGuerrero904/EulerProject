using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _6
    {
        //Sum square difference
        public static double sumSquareDifference(int num)
        {
            double sumOfSquares = 0, squareOfSum = 0;
            for (int i = 1; i <= num; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
                squareOfSum += i;
            }
            squareOfSum = Math.Pow(squareOfSum, 2);
            return (squareOfSum - sumOfSquares);
        }
    }
}
