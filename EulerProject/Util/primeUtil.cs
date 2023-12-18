using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Util
{
    public class primeUtil
    {

        public static bool isPrime(int n)
        {
            if (n < 2) return true;
            double sqrt = Math.Sqrt(n);
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
