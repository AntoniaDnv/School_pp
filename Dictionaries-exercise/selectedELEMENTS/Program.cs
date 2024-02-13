namespace selectedELEMENTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int a = 0;
            var one = new Dictionary<int, int>();
            var two = new Dictionary<int, int>();   
            var three = new Dictionary<int, int>();

           

            
            for (int i = 0; i < num[0]; i++)
            {
                int abc = int.Parse(Console.ReadLine());

                if (!one.ContainsKey(abc))
                {
                    one.Add(abc, i);
                }
                
            }
            
            for (int i = 0; i < num[1]; i++)
            {
                int abc = int.Parse(Console.ReadLine());

                if (!two.ContainsKey(abc))
                {
                    two.Add(abc, i);
                }
     
            }
             if (num[0] > num[1])
             {
                a = num[0];
             }
            else
            {
                a = num[1];
            }
           foreach(var nume in one)
           {
                int test = nume.Key;
                if (two.ContainsKey(test))
                {
                    three.Add(test, 1);
                }
           }
                
            

            foreach (var kvp in three)
            {
                Console.Write($"{kvp.Key} ");
            }
        }
    }
}