namespace hexadeciaml_to_deciamal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            double endResult = 0;
            int i = 0;
            int j = 0;
            if (input[i] == '0' && input[1] == 'b')
            {
                for (i = 2; i < input.Length; i++)
                {
                   
                    endResult =+ Math.Pow(2, j);
                    j++;
                }
                Console.WriteLine(endResult);
                j = 0;
            }
            else
            {
                if (input[0] == '0' && input[1] == 'x')
                {
                    for (i = 0; i < input.Length; i++)
                    {
                        double temp = Math.Pow(16, j);
                       
                       
                        if (nums.Contains(input[input.Length-j-1]))
                        {
                            endResult += input[input.Length - j-1] * temp;
                        }
                        else
                        {
                            switch (input[input.Length - j - 1])
                            {
                                case 'A':
                                    endResult += 10 * temp;
                                    break;
                                case 'B':
                                    endResult += 11 * temp; break;
                                case 'C':
                                    endResult += 12 * temp; break;
                                case 'D':
                                    endResult += 13 * temp; break;
                                case 'E':
                                    endResult += 14 * temp; break;
                                case 'F':
                                    endResult += 15 * temp;
                                    break;
                            }
                        }
                        j++;

                    }
                    Console.WriteLine(endResult);
                }
            }
           
          
        }
    }
}