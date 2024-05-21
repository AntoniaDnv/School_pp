namespace test_mini_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstN = input[0];
                string secondN = input[1];
                double salary = double.Parse(input[2]);
                Employee epmloyee = new Employee(firstN, secondN, salary);
                list.Add(epmloyee);

            }

            foreach (Employee employee in list.OrderByDescending(l => l.Salary))
            {
                Console.WriteLine(employee);
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

      public Employee(string firstName, string lastAnme, double salary) 
      {
            FirstName = firstName;
            LastName = lastAnme;
            Salary = salary;
      }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Salary:f2}";
        }
    }

   
}



