using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _11
    {
        public static long largestGridProduct(int[,] gird)
        {
            long maxResult = 0;
            int axln = gird.GetLength(0);
            int axh = gird.GetLength(0);
            //from left to right

            //this loop iterates between y axis
            for (int y = 0; y < (gird.GetLength(1) - 1); y++)
            {
                //this moves the pointer one to the right at the time
                for (int i = 0; i < (gird.GetLength(0) - 4); i++)
                {
                    long sum = gird[i, y] * gird[(i + 1), y] * gird[(i + 2), y] * gird[(i + 3), y];
                    if (sum > maxResult) maxResult = sum;
                }
            }
            //from the top to the bottom (the one before with inverted axis)
            for (int y = 0; y < (gird.GetLength(0) - 1); y++)
            {
                for (int i = 0; i < (gird.GetLength(1) - 4); i++)
                {
                    long sum = gird[y, i] * gird[y, (i + 1)] * gird[y, (i + 2)] * gird[y, (i + 3)];
                    if (sum > maxResult) maxResult = sum;
                }
            }
            //diagonal aggregation down right
            for (int y = 0; y < (gird.GetLength(1) - 4); y++)
            {
                for (int i = 0; i < (gird.GetLength(0) - 4); i++)
                {
                    long sum = gird[i, y] * gird[(i + 1), (y + 1)] * gird[(i + 2), (y + 2)] * gird[(i + 3), (y + 3)];
                    if (sum > maxResult) maxResult = sum;
                }
            }

            //diagonal aggregation down left
            for (int y = 0; y < (gird.GetLength(1) - 3); y++)
            {
                for (int i = (gird.GetLength(0) - 1); i > 3; i--)
                {
                    long sum = gird[i, y] * gird[(i - 1), (y + 1)] * gird[(i - 2), (y + 2)] * gird[(i - 3), (y + 3)];
                    if (sum > maxResult) maxResult = sum;
                }
            }

            return maxResult;
        }
    }
}
