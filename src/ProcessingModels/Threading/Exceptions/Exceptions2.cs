namespace Exceptions;

public static class Exceptions2
{
    public static void Runner()
    {
        new Thread(Execute).Start();
    }
    static void Execute()
    {
        try
        {
            throw null;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}