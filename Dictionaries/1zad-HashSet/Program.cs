namespace _1zad_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            HashSet<string> set = new HashSet<string>();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "IN":
                        set.Add(input[1]);
                        break;
                    case "OUT":
                        set.Remove(input[1]);
                        break;
                }
                input = Console.ReadLine().Split(", ");

            }
            if(set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach(var carNum in set)
                {
                    Console.WriteLine(carNum);
                }
            }
        }
    }
}