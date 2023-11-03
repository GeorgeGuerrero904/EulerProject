﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _2
    {
        //By considering the terms in the Fibonacci sequence whose values do not exceed n, find the sum of the even-valued terms.
        public static long fiboEvenSum(int limit)
        {
            if (limit == 2) return 2;
            List<int> list = new List<int>() { 1, 2 };
            long total = limit > 2 ? 2 : 0;
            while (list.Last() <= limit)
            {
                int sum = list.Last() + list[list.Count - 2];
                list.Add(sum);
                if (sum % 2 == 0) total += sum;
            }
            return total;
        }
    }
}
