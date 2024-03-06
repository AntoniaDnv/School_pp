namespace companyUSers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var companies = new SortedDictionary<string, List<string>>();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "End") 
            { 
                string company = command[0];
                string id = command[2];

                if(!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(id);
                }
                else if (!companies[company].Contains(id))
                {
                    companies[company].Add(id);
                }
                command = Console.ReadLine().Split();
            }
            foreach(var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach(var idies in company.Value)
                {
                    Console.WriteLine($"-- {idies}");
                }
               
            }
        }
    }
}