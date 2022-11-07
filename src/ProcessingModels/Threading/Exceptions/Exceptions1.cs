namespace Exceptions;

public static class Exceptions1
{
    public static void Runner()
    {
        try
        {
            // Worker thread
            new Thread(Execute).Start();
        }
        // Main thread
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    static void Execute()
    {
        throw null;
    }
}