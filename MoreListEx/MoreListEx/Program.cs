

 class Program
{
    static int CalculateDigitSum(int number)
    {
        return number.ToString().Sum(c => c - '0');
    }

    static string Messaging(List<int> numbers, string text)
    {
        var result = new List<char>();
        int textLength = text.Length;

        foreach (var number in numbers)
        {
            int digitSum = CalculateDigitSum(number);
            int index = digitSum <= textLength ? digitSum % textLength : (digitSum % textLength) - 1;

            char character = text[index];
            text = text.Remove(index, 1);
            textLength--;

            result.Add(character);
        }

        return new string(result.ToArray());
    }

    static void Main()
    {
        string numbersInput = Console.ReadLine();
        List<int> numbers = numbersInput.Split(' ').Select(int.Parse).ToList();

        string message = Console.ReadLine();

        string output = Messaging(numbers, message);
        Console.WriteLine(output);
    }
}