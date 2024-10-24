namespace AdvertismentMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Message message = new Message();
           
            for (int i = 0; i < n; i++) 
            {
                message.MessageCompilation();
            }

        }
    }
}
