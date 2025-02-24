using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo

{
    public class Person
    {
        private string firstName;
        private string secondName;
        private int age;
        private decimal salary;

        public Person(string firstName, string secondName, int age, decimal salary)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            Salary = salary;
        }
        public string FirstName
        {
            get => firstName;
            private set => firstName = value;
        }
        public string SecondName
        {
            get => secondName;
            private set => secondName = value;
        }
        public int Age
        {
            get => age;
            private set => age = value;
        }

        public decimal Salary
        {
            get => salary;
            private set => salary = value;
        }

        public void IncreaseSalary(decimal persentige)
        {
            if (Age > 30)
            {
                salary += salary * persentige / 100;
            }
            else 
            {
              salary += salary * persentige / 200;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName} receives {Salary:F2}";
        }
    }
}
