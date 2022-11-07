internal class Program
{
    private static void Main(string[] args)
    {
        var thread = new Thread(PrintSalaam);
        thread.Start();
        thread.Join(); // without join function, it will print last and first sentences and then wait for 5 sec.
        Console.WriteLine("Salaam printed");
    }
    static void PrintSalaam()
    {
        Console.WriteLine("Assalamu Alaikum!");
        Thread.Sleep(5000);
    }
}

