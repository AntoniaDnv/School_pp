﻿namespace MethodsLab
{
    internal class Program
    {
         static void Main(string[] args)
        {
          int firstNum = int.Parse(Console.ReadLine());
          int secondNum =int.Parse(Console.ReadLine());

            GetMax( firstNum,  secondNum);

        }

        static void GetMax(int firstNum, int secondNum)
        {
            if (firstNum>secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }
        }
    }
}