using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace PassValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            int counter = 0;
            int digitCounter = 0;
            int mistake = 0;

          

            PassCharNum( counter, mistake);
            PassConsistency(pass,mistake);

           

            DigitChecker( pass, digitCounter, mistake);

            IsPassValid( mistake);

          
        }

      

        static void PassCharNum(string pass, int counter, int mistake)
        {
            foreach (char item in pass)
            {
                counter++;
            }
            if (counter < 6 || counter > 10)
            {
              

                Console.WriteLine("Password must be between 6 and 10 characters");
                mistake++;
            }

        }
        static void PassConsistency(string pass, int mistake)
        {

            foreach (char c in pass)
            {
                if (!(Char.IsLetter(c) || Char.IsDigit(c)))
                {
                    Console.WriteLine($"Password must consist only of letters and digits");
                    mistake++;
                    break;
                }

            }

        }
        static void DigitChecker(string pass, int digitCounter, int mistake )
        {
            foreach (char c in pass)
            {
                if ( Char.IsDigit(c))
                {
                    digitCounter ++;    
                }


            }

            if (digitCounter <= 1)
            {
                Console.WriteLine("Password must have at least 2 digits");
                mistake++;
               
            }
        }

        static void IsPassValid( int mistake)
        {
           if(mistake == 0)
            {
                Console.WriteLine("Password is valid");
            }
        }

    }
 }
       
