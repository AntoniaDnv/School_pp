namespace ExamFinalExam_2srok_9klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] priceRating = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string valiue = Console.ReadLine();
            int a = priceRating[entryPoint];
            int leftDeamage = 0; 
            int rightDeamage = 0;

            for(int i = 0; i < entryPoint; i++)
            {
                switch (valiue)
                {
                    case "cheap":
                       if(priceRating[i] < a)
                       {
                            leftDeamage += priceRating[i];
                       }
                    
                        break;
                    case "expensive":
                        if (priceRating[i] >= a)
                        {
                            leftDeamage += priceRating[i];
                        }
                        break;
                }
               
            }

            for(int i = priceRating.Length-1;i > entryPoint;i--)
            {
                switch (valiue)
                {
                    case "cheap":
                        if (priceRating[i] < a)
                        {
                            rightDeamage += priceRating[i];
                        }

                        break;
                    case "expensive":
                        if (priceRating[i] >= a)
                        {
                            rightDeamage += priceRating[i];
                        }
                        break;
                }
               
            }
            if(leftDeamage == rightDeamage)
            {
                Console.WriteLine($"Left - {leftDeamage}");
                return;
            }
            if (rightDeamage > leftDeamage)
            {
                Console.WriteLine($"Right - {rightDeamage}");
            }
            else 
            {
                Console.WriteLine($"Left - {leftDeamage}");
            }
            
           
        }
    }
}