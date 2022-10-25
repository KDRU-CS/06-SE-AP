namespace MyTestFramework.src;

public class MathLib
{
    public static double Add(params double[] numbers)
    {
        var result = 0.0;
        foreach (var item in numbers)
        {
            result += item;
        }

        return result;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }
}