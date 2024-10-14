using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }

      
        public void Print()
        {
            Console.WriteLine($"{this.Face} {this.Suit}");
        }
    }

}
