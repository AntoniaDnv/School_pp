namespace Newspaper
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] newsPaper = Console.ReadLine().Split(", ");
            string title = newsPaper[0];
            string text = newsPaper[1];
            string writer = newsPaper[2];

            var news = new News(title, text, writer);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                string[] input = Console.ReadLine().Split(": ");
                string command = input[0];
                string content = input[1];

                switch (command) 
                {
                    case "Edit":
                        news.Edit(content);
                        break;
                    case "ChangeWriter":
                        news.ChangeWriter(content);
                        break;
                    case "Rename":
                        news.Rename(content);
                        break;

                }
            }

            Console.WriteLine($"{news.Title} - {news.Text}: {news.Writer}");
        }
    }
}
