using System.Security.Cryptography.X509Certificates;

namespace A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double period = double.Parse(Console.ReadLine());
            string size = (Console.ReadLine()); 
            string wifi= Console.ReadLine();
            int payMonths = int.Parse(Console.ReadLine());
            double bill = 0;

            if(period==1)
            {
                switch (size)
                {
                    case "S":
                        bill = 12.98;
                        break;
                    case "M":
                        bill = 16.99;
                        break;
                    case "L":
                        bill = 28.98;
                        break;
                    case "XL":
                        bill = 39.99;
                        break;

                }
            }
            else
            {
                switch (size)
                {
                    case "S":
                        bill = 10.58;
                        break;
                        case "M":
                        bill = 15.09;
                        break;
                        case "L":
                        bill = 25.59;
                        break;
                    case "XL":
                        bill = 30.79;
                        break;

                }
            }
            if (wifi == "y")
            {
                if (bill <= 10)
                {
                    bill = bill + 6.50;
                }
                else if (bill <=30 &&  bill > 10)
                {
                    bill = bill + 5.35;
                }
                else if ( bill > 30)
                {
                    bill = bill + 4.85;
                }

            }

            if (period == 2)
            {
                bill = bill - bill * 4.25;
            }
            double endSum = bill * payMonths;

            Console.WriteLine(endSum);

        }
    }
}