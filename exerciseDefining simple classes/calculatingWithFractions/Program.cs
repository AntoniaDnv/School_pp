using Fractions;
using System.Security.Cryptography.X509Certificates;
namespace calculatingWithFractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var input =  Console.ReadLine().Split().ToArray();

            int[] firstFractionInput = input[0].Split("/").Select(int.Parse).ToArray();
            int[] secondFractionInput = input[2].Split("/").Select(int.Parse).ToArray();
            string sign = input[1];

            Fraction fractionOne = new Fraction(firstFractionInput[0], firstFractionInput[1]);
            Fraction fractionTwo = new Fraction(secondFractionInput[0], secondFractionInput[1]);
            if(sign == "+")
            {
                Console.WriteLine($"{fractionOne} {sign} {fractionTwo} = {fractionOne + fractionTwo}");
            }
            else
            {
                Console.WriteLine($"{fractionOne} {sign} {fractionTwo} = {fractionOne - fractionTwo}");
            }
        }
    }
}
