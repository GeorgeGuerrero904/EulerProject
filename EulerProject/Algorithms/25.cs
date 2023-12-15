using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _25
    {
        public static int digitFibonacci(int n)
        {
            List<BigInteger> el = new List<BigInteger>() { 1, 1 };
            bool digitFound = false;
            while (!digitFound)
            {
                BigInteger sum = el.Last() + el.ElementAt(el.Count - 2);
                el.Add(sum);
                if (sum.ToString().Length == n) digitFound = true;
            }
            return el.Count;
        }

    }
}
