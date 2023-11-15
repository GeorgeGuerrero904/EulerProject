using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _17
    {

        public static int numberLetterCounts(int limit)
        {
            int totalLetters = 0;
            for (int i = 0; i < limit; i++)
            {
                string number = HumanFriendlyInteger.IntegerToWritten(i);
                number = String.Join("", number.Split(' '));

                totalLetters += number.Length;
            }
            return totalLetters;
        }
    }
}
