using System.Text;

namespace SkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            decifering(word);


        }
     
        static void decifering(string word)
        {
            List<int> nums = new List<int>();

            List<int> takeList = new List<int>();

            List<int> skipList = new List<int>();

            StringBuilder res = new StringBuilder();

            List<string> notNums = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    nums.Add(int.Parse(word[i].ToString()));
                }
                else
                {
                    notNums.Add(word[i].ToString());
                }

            }
            for (int i = 0; i < nums.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(nums[i]);
                }
                else
                {
                    skipList.Add(nums[i]);
                }
            }

            int skip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(notNums);

                temp = temp.Skip(skip).Take(takeList[i]).ToList();

                res.Append(string.Join("", temp));

                skip += takeList[i] + skipList[i];
            }

            Console.WriteLine(res.ToString());
        }
    }
}