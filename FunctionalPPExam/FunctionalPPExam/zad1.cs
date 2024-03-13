namespace FunctionalPPExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                  .Split()
                  .ToArray();
            Action<string[]> action = (string[] names) =>
            {
               for(int i  = 0; i < names.Length; i++)
                {
                    names[i] ="sir " + names[i];
                }
            };
            action(names);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

           
        }
    }
}