using System.ComponentModel;

namespace CheckStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            List <string> absent = new List<string>();
            List <string> here = new List<string>();

            List<string> a = new List<string>();

            int n = int.Parse(Console.ReadLine());  

            for(int i = 0; i < n; i++)
            {
               List<string> names = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (absent.Contains(names[0]) && names.Count > 3)
                {
                    Console.WriteLine($"{names[0]} is already in the list!");
                }

                if (absent.Contains(names[0]) && names.Count <= 3)
                {
                    Console.WriteLine($"{names[0]} is in class!");
                    absent.Remove(names[0]);
                    here.Add(names[0]);
                }

                if (names.Count >  3)
                {
                    if (!(absent.Contains(names[0])))
                    {
                        absent.Add(names[0]);
                    }
                    

                }
                else
                {
                    here.Add(names[0]);
                }

               



            }
            for(int i = 0;i < absent.Count;i++)
            {
                Console.WriteLine(string.Join(" ", absent[i]));
            }
           
        }
    }
}