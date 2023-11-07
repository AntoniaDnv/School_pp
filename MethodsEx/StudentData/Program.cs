namespace StudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            GetStudentData(name, age);
            void GetStudentData(string name, int age )=>
           
                Console.WriteLine($"{name} is studying in {age} grade. ");
           
        }
    }
}