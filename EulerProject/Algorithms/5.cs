using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    internal class _5
    {
        public static int smallestMult(int n)
        {
            bool Scontinu = true;
            int smint = 1;
            while (Scontinu)
            {
                bool doesMatch = true;
                for (int i = 1; i <= n && doesMatch; i++)
                {
                    if (smint % i != 0) doesMatch = false;
                }
                if (!doesMatch)
                {
                    smint++;
                }
                else
                {
                    Scontinu = false;
                }
            }
            return smint;
        }
    }
}
