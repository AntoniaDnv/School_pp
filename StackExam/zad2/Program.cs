namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            
            
            int[] numsFood = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
          
            Queue<int> food = new Queue<int>(numsFood);
            Queue<int> ints = new Queue<int>(numsFood);
            int max = int.MinValue;

           for(int i = 0; i< ints.Count; i++)
           {
                int a = ints.Peek();

                if (a > max)
                {
                    max = a;
                }
                ints.Dequeue();

           }
            
            while(food.Count>0)
            {
            
                if(quantity >= food.Peek())
                {
                    quantity = quantity - food.Peek();
                    food.Dequeue();
                }
                else
                {
                    Console.WriteLine(max);
                    Console.Write("Orders left: ");
                    for(int i = -2; i < food.Count;i++)
                    {
                        Console.Write(food.Dequeue() + " ");
                    }
                    return;
                   
                }

              

            }
            Console.WriteLine(max);
            Console.WriteLine("All orders are completed");



        }
    }
}