namespace AgainstBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int flowers = int.Parse(Console.ReadLine());
            int[] spray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
          List<int> list = new List<int>(spray);
           
            bool die = false;
            int days = 0;
           
           for(int i = 0; i <list.Count; i ++)
            {
                
                if (list[i] < list[i+1])
                {
                   
                    list.RemoveAt(i+1);
                    if((CheckIfDies(list)) == true)
                    {
                        Console.WriteLine(list.Count -1);
                        return;
                    }
                    i--;
                    
                }
                days++;
            }
                
                
           
            

        }
         static bool  CheckIfDies( List<int> list) 
                {
                    bool a = false;
           
                    for (int i= 0; i<list.Count - 1; i++)
                    {
                       if(list[i] < list[i + 1])
                       {
                          a = false;
                           break;
                       }
                        a = true;
                
                    }
                       return a;

                }
    }
}