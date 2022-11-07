namespace SharedResources;

public static class SharedResource1
{
    static bool IsCompleted { get; set; }
    public static void Runner()
    {
        // worker thread
        Thread thread = new(Salaam);
        thread.Start();

        // main thread
        Salaam();
    }
    static void Salaam()
    {
        if (!IsCompleted)
        {
            Console.WriteLine("Assalamu Alaikum!");
            IsCompleted = true;
        }
    }
}