using System;
using System.Diagnostics.Tracing;

namespace MixUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numsOne = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();


            List<int> numsTwo = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            List<int> word = new List<int>();
            List<int> finalWord =new List<int> ();
            

            Calculations( numsOne, numsTwo, word, finalWord);
        }

        static void Calculations(List<int> numsOne, List<int> numsTwo, List<int> word, List<int> finalWord)
        {

            if(numsOne.Count > numsTwo.Count) 
            { 
                numsTwo.Reverse();
                for(int i = 0; i < numsTwo.Count; i++)
                {
                    word.Add(numsOne[i]) ;
                    word.Add(numsTwo[i]);

                }
   

                for(int i = 0; i< word.Count(); i++)
                {
                    int numsBorderOne = numsOne[numsOne.Count - 1];
                    int numsBorderTwo = numsOne[numsOne.Count - 2];
                    int BigBorder = 0;
                    int smallBorder = 0 ;
                    if (numsBorderOne > numsBorderTwo)
                    {
                       BigBorder = numsBorderOne;
                        smallBorder = numsBorderTwo;
                       
                    }
                    else
                    {
                       
                       BigBorder = numsBorderTwo ; 
                        smallBorder = numsBorderOne;
                    }
                    if(word[i] > smallBorder && word[i] < BigBorder)
                    {
                        finalWord.Add(word[i]) ;
                    }

                    finalWord.Sort();
                }

                 
            
            }
            else
            {
                numsTwo.Reverse();

                for (int i = 0; i < numsOne.Count; i++)
                {
                    word.Add(numsOne[i]);
                    word.Add(numsTwo[i]);

                }
                for (int i = 0; i < word.Count(); i++)
                {
                    int numsBorderOne = numsTwo[numsTwo.Count - 1];
                    int numsBorderTwo = numsTwo[numsTwo.Count - 2];
                    int BigBorder = 0;
                    int smallBorder = 0;
                    if (numsBorderOne > numsBorderTwo)
                    {
                        BigBorder = numsBorderOne;
                        smallBorder = numsBorderTwo;

                    }
                    else
                    {

                        BigBorder = numsBorderTwo;
                        smallBorder = numsBorderOne;
                    }
                    if (word[i] > smallBorder && word[i] < BigBorder)
                    {
                        finalWord.Add(word[i]);
                    }

                    finalWord.Sort();
                }
            }
            Console.WriteLine(string.Join(" ", finalWord));

        }
    }
}