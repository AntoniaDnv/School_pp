using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfWar
{
    public class Cards
    {
        public CardFace Face { get; set; }
        public CardSuit Suits { get; set; }

        public override string ToString()
        {
           

            int face = (int)Enum.Parse(typeof(CardFace), this.Face.ToString());

            char suite = (char)this.Suits;
          
            if (face > 10)
            {
                char charFace = this.Face.ToString()[0];

                return $"{charFace}{suite}";
            }
              
           return $"{face}{suite}";
          
           


        }
    }
  
}
