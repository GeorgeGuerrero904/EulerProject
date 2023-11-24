using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _22
    {

        public static int namesScores(string[] arr)
        {
            int total = 0;
            arr = arr.OrderBy(x => x).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                string s = arr[i];
                char[] chars = s.ToCharArray();
                int individualSum = 0;
                foreach (char c in chars)
                {
                    individualSum += ((int)char.ToUpper(c) - 64);
                }
                total += individualSum*(i+1);
            }

            return total;
        }
    }
}
