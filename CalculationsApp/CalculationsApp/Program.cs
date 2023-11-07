namespace CalculationsApp
{
    internal static class Program
    {
       private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operations
        }
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormCalculations());
        }
    }
}