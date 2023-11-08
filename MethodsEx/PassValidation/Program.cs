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
           
            bool done = false;

           done= PassCharNum( pass,counter, done);
            done = PassConsistency(pass,done);

           

            done = DigitChecker(pass, digitCounter, done);

            IsPassValid( done);

          
        }

      

    static bool PassCharNum(string pass, int counter, bool done)
        {
            foreach (char item in pass)
            {
                counter++;
            }
            if (counter < 6 || counter > 10)
            {
              

                Console.WriteLine("Password must be between 6 and 10 characters");
                return true;
                
            }
            return false;

        }
        static bool PassConsistency(string pass, bool done)
        {

            foreach (char c in pass)
            {
                if (!(Char.IsLetter(c) || Char.IsDigit(c)))
                {
                    Console.WriteLine($"Password must consist only of letters and digits");
                   return true;
             
                }
              

            }
            return false;


        }
        static bool DigitChecker(string pass, int digitCounter, bool done )
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
               

                return true;
            }
            else
            {
                return false;
            }
         
        }

        static void IsPassValid( bool done)
        {
           if(done == false)
            {
                Console.WriteLine("Password is valid");
            }
        }

    }
 }
       
