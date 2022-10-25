namespace IntroExample;

public class MathLib
{
    public static int AddNumbers(int param1, int param2, int param3)
    {
        return param1 + param2 + param3;
    }

    public static int SubtractNumbers(int param1, int param2)
    {
        return param1 - param2;
    }

    public static void PrintNumbers(List<int> numbers)
    {
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsEven(int number)
    {
        if(number % 2 == 0)
        {
            return true;
        }
        return false;
    }
}