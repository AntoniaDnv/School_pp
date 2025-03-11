using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    public class Box
    {
        public double height;
        public double width;
        public double length;

        public Box(double legth, double width, double height)
        {
            Length = legth;
            Width = width;
            Height = height;
        }
           
        public double Height 
        {
            get => height;
            set 
            {
                if (value <= 0) 
                {
                 throw new ArgumentException(nameof(value));
                }
                height = value;
            }
        }
        public double Width 
        { 
            get => width; 
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(nameof(value));
                }
                width = value;

            } 
        }
        public double Length
        {
            get => length; 
            set
            {
              if(value < 0)
              {
                 throw new ArgumentException(nameof(value));
              }
              length = value;
            }
        }

        public void CalculateArea()
        {
            Console.WriteLine($"Surface area - {2*(Length*Width + Length*Height + Height*Width):F2}");
        }

        public void CalculateLateralArea()
        {
            Console.WriteLine($"Lateral area - {2 * Height * (Width + Length):F2}");
        }

        public void CalculateVolume()
        {
            Console.WriteLine($"Volume - {Width * Length * Height:F2}");
        }
    }
}
