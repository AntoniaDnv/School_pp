using System.Text;

namespace Find_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder(); 
            for(int i = 0; i < n; i++)
            {
              
                string input = Console.ReadLine();

                string namee = name(input);
                int agee = int.Parse(age(input));

                if(namee.Length > 0 )
                {
                    Console.WriteLine($"{namee} is {agee} years old.");
                }

            }
        }
        static string name(string input)
        {
            int start = input.IndexOf('@');
            if (start!= -1)
            {
                int end = input.IndexOf('|', start);
               
                if (end != -1)
                {
                    return input.Substring(start + 1, end- start - 1);
                }
                   
            }
            return "";
        }
        static string age(string input)
        {
            int start = input.IndexOf('#');
            if (start != -1)
            {
                int end = input.IndexOf('*', start);

                if (end != -1)
                {
                    return input.Substring(start + 1, end - start - 1);
                }

            }
            return "";
        }
    }
}