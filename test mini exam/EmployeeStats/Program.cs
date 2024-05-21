namespace EmployeeStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();  
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            List<string> names = new List<string>();
            string bestDepartment = "";
            int maxValue = 0;
  
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];
                Employee employee = new Employee(name, salary, department);

                list.Add(employee);

                if (dictionary.ContainsKey(department))
                {
                    dictionary[department] += salary;
                }
                else
                {
                    dictionary.Add(department, salary);
                }

            }
            foreach (string department in dictionary.Keys)
            {
                //if(maxValue < dictionary[department])
                //{
                //    bestDepartment = department;

                //  }
                double a = dictionary[department];
                foreach (var salary  in dictionary.Values)
                {
                    if(a >= salary)
                    {
                        bestDepartment = department;
                    }
                    else
                    {
                        break;
                    }
                }
             
            }
        

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            foreach (Employee employee in list.OrderByDescending(l => l.Salary))
            {
                if (employee.Department == bestDepartment)
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                }
            }

        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
    }
}