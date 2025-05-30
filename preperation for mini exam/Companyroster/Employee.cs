﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companyroster
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; } = "n/a";  
        public int Age { get; set; } = -1;

        public Employee(string name, decimal salary, string position, string department, string email = "n/a", int age = -1)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }
    }
}
