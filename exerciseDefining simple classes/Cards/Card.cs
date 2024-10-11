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
        private readonly string face;
        private readonly string suit;

        public String Face {  get; set; }
        public String Suit { get; set; }

        public Card(string face, string suit, string facee, string suite)
        {

        }
        public void Print()
        {
            Console.WriteLine();
        }
    }

}
