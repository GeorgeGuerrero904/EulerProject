using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    internal class _4
    {
        //Largest palindrome product
        public static int largestPalindromeProduct(int n)
        {
            List<int> palindtromes = new List<int>();
            int n1 = 1;
            int limit = (Convert.ToUInt16("1" + new string('0', n)) - 1);
            while (n1 <= limit)
            {
                int n2 = 1;
                while (n2 <= limit)
                {
                    int res = n1 * n2;
                    string str1 = res.ToString();
                    char[] ar = str1.ToCharArray();
                    Array.Reverse(ar);
                    string str2 = new string(ar);
                    if (str1.Equals(str2)) palindtromes.Add(res);

                    n2++;
                }
                n1++;
            }

            return palindtromes.Max();
        }
    }
}
