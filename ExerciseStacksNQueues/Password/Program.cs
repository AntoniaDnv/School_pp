namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food =double.Parse( Console.ReadLine());

            double hay = double.Parse(Console.ReadLine());

            double cover = double.Parse(Console.ReadLine());

            
            
            double weight = double.Parse(Console.ReadLine());

            
            int days = 0;
            int month = 0;
            food *=1000;
            weight *=1000;
            hay *=1000;
            cover *=1000;
            while (month != 30)
            {
            
                if(days == 3)
                {
                    days = 0;
                    month--;
                   
                }
                else if(days ==0 )
                {
                    food -= 300;  
                    days++;
              
                }
                else if(days ==1)
                {
                    food -= 300;
                    hay = hay - food * 0.05;
                    
                    days++;
              
                }              
                else  if(days ==2 ) 
                {
                    cover = cover - weight * 1 / 3;
                    food -= 300;
                    days++;
                }

                month++;
               
                
                if(food <= 0)
                {
                    break;
                }
            }

            if(month<30 )
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                cover/=1000;
                food/=1000;
                Console.WriteLine($"Everything is fine! Puppy is happy! Food:{food:f2}, Hay: {hay}, Cover: {cover:f2}.");
            }



        }
    }
}