namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double under200 = 0;
            double btw2And4 = 0;
            double btw4And6 = 0;
            double btw6And8 = 0;
            double above8 = 0;
            double ff = n / 100;
            

            for (double i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    under200++;
                }
                else if (num >= 200 && num <= 399)
                {
                    btw2And4++;
                }
                else if (num >= 400 && num <= 599)
                {
                    btw4And6++;
                }
                else if (num >= 599 && num <= 799)
                {
                    btw6And8++;
                }
                else if(num >= 800)
                {
                    above8++;
                }
            }

            Console.WriteLine($"{under200/ff:f2}");
            Console.WriteLine($"{btw2And4 / ff:f2}");
            Console.WriteLine($"{btw4And6 / ff:f2}");
            Console.WriteLine($"{btw6And8 / ff:f2}");
            Console.WriteLine($"{above8 / ff:f2}");
        
        }
    }
}