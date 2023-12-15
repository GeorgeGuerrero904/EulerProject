using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _24
    {

        public static long lexicographicPermutations(int n)
        {
            int[] factorials = new int[] { 362880, 40320, 5040, 720, 120, 24, 6, 2, 1, 1 };
            int[] digits = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string permutation = "";
            for (int i = 0; i < 10; i++)
            {
                int val = n / factorials[i];
                int dig = digits.ElementAt(val);
                digits = digits.Where(x => x != dig).ToArray();

                permutation += dig;
                n = n % factorials[i];


            }

            return Convert.ToInt64(permutation);
        }
    }
}
