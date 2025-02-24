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

        public Person(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
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

        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName} is {this.Age} years old.";
        }
    }
}
