using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregovorPrediTest10klas
{
    public class Card
    {
        private string Face { get; set; }
        private string Suit { get; set; }

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            return $"{Face} {Suit}";
        }
    }
}
