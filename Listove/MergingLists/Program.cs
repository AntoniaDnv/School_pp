namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> listTwo = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            for(int i = 0; i < listOne.Count; i++)
            {
                if (listOne.Count > listTwo.Count)
                {
                    while (listTwo.Count > 0)
                    {
                        Console.Write(listOne[i]);
                        Console.Write(listTwo[i]);
                        listTwo.RemoveAt(i);
                        i++;
                    }


                }
                else
                {
                    while (listOne.Count > 0)
                    {
                        Console.Write(listOne[i]);
                        Console.Write(listTwo[i]);
                        listOne.RemoveAt(i);
                        i++;
                    }

                }

            }
           
        }
    }
}