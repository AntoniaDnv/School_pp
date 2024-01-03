namespace inventoryPeoblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] m = Console.ReadLine()
                .Split(", ");
              
            Stack<string> materials = new Stack<string>(m);

            string[] command = Console.ReadLine()
                .Split();
            while (command[0] != "Craft!")
            {
                switch(command[0])
                {
                    case "Collect":
                        if (materials.Contains(command[0]))
                        {
                            break;
                        }
                        else
                        {
                            materials.Push(command[0]);
                        }
                        break;

                    case "Drop":
                        break;

                    case "Combine":
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}