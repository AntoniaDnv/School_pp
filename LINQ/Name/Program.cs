namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
               
            bool correct = false;
            if(name.Length > 3 )
            {
                IsNameValid(name, correct);
            }
            else
            {
                NameNotValid();
            }

        }

        static void IsNameValid(string name, bool correct)
        {
            
            bool a = Char.IsUpper(name[0]);
           
            if (a == true)
            {
                bool containsInt = name.Any(char.IsDigit);
                if (containsInt == false)
                {
                    Console.WriteLine($"Hello, {name}");

                    for (int j = 0; j < name.Length; j++)
                    {
                        char ch = name[j];
                        Console.WriteLine((int)ch + 10);
                    }

                }
                else
                {
                    NameNotValid();
                }
            }
            else
            {
                NameNotValid();
            }

        }

        static void NameNotValid()
        {
            Console.WriteLine("Invalid name!");
            return;
        }
    }
}