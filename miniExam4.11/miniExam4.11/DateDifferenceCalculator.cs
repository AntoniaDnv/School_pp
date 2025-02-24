using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniExam4._11
{
    public class DateDifferenceCalculator
    {
        public int CalculateDaysDifference(string date1, string date2)
        {

            DateTime parsedDate1 = DateTime.Parse(date1);
            DateTime parsedDate2 = DateTime.Parse(date2);


            TimeSpan difference = parsedDate1 - parsedDate2;


            return Math.Abs(difference.Days);
        }
    }
}
