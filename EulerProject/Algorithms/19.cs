using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Algorithms
{
    public class _19
    {
        public static int countingSundays(int firstYear, int lastYear)
        {
            int sundaysCount = 0;
            for (int year = firstYear; year <= lastYear; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    
                    DateTime dayOnTime = new DateTime(year, month, 1);
                    if (dayOnTime.DayOfWeek == DayOfWeek.Sunday)
                    {
                        sundaysCount++;
                    }

                }
            }
            return sundaysCount;
        }
    }
}
