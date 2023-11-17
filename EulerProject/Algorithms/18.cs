using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _18
    {
        public static int maximumPathSumI(int[,] triangle)
        {
            int xIndex = 0, totalSum = triangle[0, 0];
            for (int i = 1; i < triangle.GetLength(1); i++)
            {
                int adLeft = triangle[(xIndex == 0 ? 0 : (xIndex - 1)), i];
                int adDown = triangle[xIndex, i];
                int adRight = triangle[(xIndex == (triangle.GetLength(0) - 1) ? (triangle.GetLength(0) - 1) : (xIndex + 1)), i];
                //adLeft is the greatter
                if (adLeft > adRight && adLeft > adDown)
                {
                    totalSum += adLeft;
                    xIndex = (xIndex == 0 ? 0 : (xIndex - 1));
                }
                //adRght is the greatter
                else if (adRight > adLeft && adRight > adDown)
                {
                    totalSum += adRight;
                    xIndex = (xIndex == (triangle.GetLength(0) - 1) ? (triangle.GetLength(0) - 1) : (xIndex + 1));
                }
                //adDown is the grater
                else
                {
                    totalSum += adDown;
                    //xIndex persist
                }
            }

            return totalSum;
        }



    }
}
