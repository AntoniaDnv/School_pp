using System.Data;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sec = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            int a = sec;
            int b = freeWindow;
            Queue<string> queue = new Queue<string>();
            while (command!= "END")
            {
                
                if (command == "green")
                {
                   string curCar = " ";
                    while (sec>0)
                    {
                        string car = " ";
                        if (queue.Count > 0)
                        {
                            car = queue.Dequeue();

                        }
                        else
                        {
                            break;
                        }

                        sec-= car.Length;
                        curCar = car;
                        counter++;
                    }

                    if(sec < 0)
                    {
                        sec = Math.Abs(sec);
                        if(sec > freeWindow)
                        {
                            sec -= freeWindow;
                            Console.WriteLine("Crash on the crossroad!");
                            Console.WriteLine($"{curCar} was hit at {curCar[curCar.Length-sec]}.");
                            return;
                        }
                    }

                   
                }
                else
                {
                    queue.Enqueue(command);

                }

                command = Console.ReadLine();
                sec = a;
                freeWindow = b;
            }
            Console.WriteLine($"No crash happened.");
            Console.WriteLine($"{counter} total cars passsed the crosroad.");


        }
    }
}