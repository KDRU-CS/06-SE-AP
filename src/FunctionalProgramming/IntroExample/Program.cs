using static IntroExample.MathLib;

namespace IntroExample;

public class Program
{
    public delegate int AddNumbersDelegate(int num1, int num2);
    public static void Main()
    {
        // Func<int, int, int, int> Addition = AddNumbers;
        // int addResult = Addition(10, 20, 30);
        // Console.WriteLine($"Addition = {addResult}");

        // Action<List<int>> PrintNumber = PrintNumbers;
        // PrintNumber(new List<int> { 1, 2, 3, 4, 5, 6 });

        // Predicate<int> IsEvenNumber = IsEven;
        // Console.WriteLine(IsEvenNumber(3));

        // AddNumbersDelegate subtract = new AddNumbersDelegate(SubtractNumbers);
        // Console.WriteLine(subtract(12, 3));
    }
}