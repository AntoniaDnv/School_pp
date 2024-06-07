namespace FinalExamPreperation_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;
            while((input = Console.ReadLine()) != "Decode")
            {
             string[] splited = input.Split("|");

                string command = splited[0];

                switch(command)
                {
                    case "Move":
                      
                        int lettersNum = int.Parse(splited[1]);
                        string textToMove = message.Substring(0, lettersNum);
                        message = message.Remove(0, lettersNum);    
                        message += textToMove;
                       
                        break;
                  
                    case "Insert":
                        
                        int index = int.Parse(splited[1]);
                        string value = splited[2];
                        message = message.Insert(index, value);
                        
                        break;
                    
                    case "ChangeAll":

                        string substring = splited[1];
                        string replacment = splited[2];
                        message = message.Replace(substring, replacment);

                    break;

                }
            }

            Console.WriteLine($"The decrypted messede is: {message}");
        }
    }
}