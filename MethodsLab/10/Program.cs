namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            GetMax(type);
        }
        static void GetMax(string type)
        {
           
            switch (type)
            {
                case "int":
                   
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    if (a>b)
                    {
                        Console.WriteLine(a);
                    }
                    else 
                    {
                        Console.WriteLine(b); 
                    }
                   
                    
                    break;

                case "char":
                   
                    char e = char.Parse(Console.ReadLine());
                    char f = char.Parse(Console.ReadLine());

                    if (e<f)
                    {
                        Console.WriteLine(f);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                   
                    break;


                case "string":

                    string c = Console.ReadLine();
                    string d = Console.ReadLine();
                    int counter = 0;
                    foreach( char g  in c)
                    {
                        foreach(char h in d)
                        {
                            if (g> h)
                            {
                                counter++;
                            }
                            else
                            {
                                counter--;
                            }
                        }
                    }
                    if (counter > 0)
                    {
                        Console.WriteLine(c);
                    }
                    else { Console.WriteLine(d); }
                    break;
                default:
                    break;
            }
        }
    }
}