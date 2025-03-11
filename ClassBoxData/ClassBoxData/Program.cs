using System.ComponentModel.DataAnnotations;

namespace ClassBoxData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                var box = new Box(length, width, height);

                box.CalculateArea();
                box.CalculateLateralArea();
                box.CalculateVolume();
            }
            catch (Exception ex) 
            {            
                Console.WriteLine(ex.Message);
            }

        }
    }
}
