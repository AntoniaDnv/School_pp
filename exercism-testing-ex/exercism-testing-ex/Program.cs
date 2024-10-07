using System.Globalization;

namespace exercism_testing_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            string[] nums = phoneNumber.Split("-");

            bool isNewYork = true;
            bool isFakeYork = true;
            string localNumber = nums[2];
            if (nums[0] == "212")
            {
             isNewYork = true;
            }
            else
            {
               isNewYork = false;
            }
            if (nums[1] == "555")
            {
               isFakeYork = true;
            }
            else
            {
                 isNewYork = false;
            }
         (bool, bool, string) test = (isNewYork, isFakeYork, localNumber);
            return test;
        }
    }

    
}
