using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exerciseDefining_simple_classes
{
    public class DateCounter
    {
        public int CalculateDifference(string firstDate, string secondDate)
        {
            DateTime dateFirstToDateTime = new DateTime(firstDate.Split("/").Select(int.Parse).ToArray()[0],
             firstDate.Split("/").Select(int.Parse).ToArray()[1],
             firstDate.Split("/").Select(int.Parse).ToArray()[2]
                );
            DateTime dateSecondToDateTime = new DateTime(secondDate.Split("/").Select(int.Parse).ToArray()[0],
             secondDate.Split("/").Select(int.Parse).ToArray()[1],
             secondDate.Split("/").Select(int.Parse).ToArray()[2]
               );
            return Math.Abs((dateFirstToDateTime - dateSecondToDateTime).Days);
        }
    }
}
