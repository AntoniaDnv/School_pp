using System.Xml.Linq;

namespace sum_of_intigers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int sum = 0;
            int currentNum = 0;
            try
            {
                int[] nums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

                for (int i = 0; i < nums.Length; i++)
                {
                    currentNum = nums[i];
                    sum += currentNum;
                    Console.WriteLine($"Element '{currentNum}' processed - current sum: {sum}");
                }
            }
            catch(OverflowException)
            {
                Console.WriteLine($"The element {currentNum} is out of range!");
            }
            catch(FormatException)
            {
                Console.WriteLine($"The element {currentNum} is in wrong format!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}