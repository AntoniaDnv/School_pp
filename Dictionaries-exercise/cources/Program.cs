namespace cources
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, SortedSet<string>>();
            string[] input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            while(input[0] != "end")
            {
                string coursName = input[0];
                string studentName = input[1];

                if (!courses.ContainsKey(coursName))
                {
                    
                    courses.Add(coursName,new SortedSet<string>());
                }
                courses[coursName].Add(studentName);
                input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach(var cours in courses.OrderByDescending(c => c.Value.Count))
            {

                Console.WriteLine($"{cours.Key}: {cours.Value.Count}");
                foreach(var student in cours.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}