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
        public static long largestGridProduct(int[,] grid)
        {
            long maxResult = 0;
            //from left to right

            //this loop iterates between y axis
            for (int y = 0; y < (grid.GetLength(1) - 1); y++)
            {
                //this moves the pointer one to the right at the time
                for (int i = 0; i < (grid.GetLength(0) - 4); i++)
                {
                    long sum = grid[i, y] * grid[(i + 1), y] * grid[(i + 2), y] * grid[(i + 3), y];
                    if (sum > maxResult) maxResult = sum;
                }
            }
            //from the top to the bottom (the one before with inverted axis)
            for (int y = 0; y < (grid.GetLength(0) - 1); y++)
            {
                for (int i = 0; i < (grid.GetLength(1) - 4); i++)
                {
                    long sum = grid[y, i] * grid[y, (i + 1)] * grid[y, (i + 2)] * grid[y, (i + 3)];
                    if (sum > maxResult) maxResult = sum;
                }
            }
            //diagonal aggregation down right
            for (int y = 0; y < (grid.GetLength(1) - 4); y++)
            {
                for (int i = 0; i < (grid.GetLength(0) - 4); i++)
                {
                    long sum = grid[i, y] * grid[(i + 1), (y + 1)] * grid[(i + 2), (y + 2)] * grid[(i + 3), (y + 3)];
                    if (sum > maxResult) maxResult = sum;
                }
            }

            //diagonal aggregation down left
            for (int y = 0; y < (grid.GetLength(1) - 3); y++)
            {
                for (int i = (grid.GetLength(0) - 1); i > 3; i--)
                {
                    long sum = grid[i, y] * grid[(i - 1), (y + 1)] * grid[(i - 2), (y + 2)] * grid[(i - 3), (y + 3)];
                    if (sum > maxResult) maxResult = sum;
                }
            }

            return maxResult;
        }
    }
}
