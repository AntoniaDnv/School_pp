using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vhodno2srok10klas
{
    public class Customer
    {
        private int customerId;
        private string name;
        private int age;
        private string email;
        private int bonusPoints;
     

        public int CustomerId {  get { return customerId; } set { customerId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int BonusPoints { get { return bonusPoints; } set {  bonusPoints = value; } }

       
        public Customer(int customerId, string name, int age, string email)
        {
            this.CustomerId = customerId;
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.BonusPoints = 10;
        }
        public void AddBonusPoints(int points)
        {
            bonusPoints += points;
            Console.WriteLine($"You have {bonusPoints} bonus points.");
        }

        public void ExchangePoints(int points)
        {
            if (points > BonusPoints) 
            {
                Console.WriteLine("You do not have enough bonus points.");
            }
            else
            {
                BonusPoints -= points;
                Console.WriteLine($"You have {BonusPoints} points left.");
            }

        }
    }
}
