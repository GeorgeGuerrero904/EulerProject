using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _23
    {
        public static int sumOfNonAbundantNumbers(int n)
        {
            int total = 0;
            List<int> abundantNumbers = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (isAbundant(i)) abundantNumbers.Add(i);
                if (!isResultOfSum(abundantNumbers, i)) total += i;
            }
            return total;
        }

        public static bool isAbundant(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) sum += i;
            }
            if (sum > n) return true;
            else return false;
        }

        public static bool isResultOfSum(List<int> abundantNumbers, int n)
        {
            for (int i = 0; i < abundantNumbers.Count; i++)
            {
                int currentNumber = abundantNumbers.ElementAt(i);
                for (int j = 0; j < abundantNumbers.Count; j++)
                {
                    int sumResult = currentNumber + abundantNumbers.ElementAt(j);
                    if (sumResult == n) return true;
                }
            }

            return false;
        }

    }
}
