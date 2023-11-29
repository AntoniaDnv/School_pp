namespace OrderStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> finalList = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<int> ints = new List<int>();   

            for(int i = 0; i < finalList.Count; i++)
            {
                List<int> list = finalList[i]
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                list.Reverse();

                
                    ints.AddRange(list);
                  
               
            }
            ints.Reverse();
            Console.WriteLine(string.Join(" ",ints));


        }

    }
}