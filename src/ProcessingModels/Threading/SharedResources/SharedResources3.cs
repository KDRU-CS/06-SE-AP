namespace SharedResources;

// run 100 or more times, it won't happen that it prints the line twice.
// for ($i=1; $i -le 100; $i++) {dotnet run; echo "end"}
public static class SharedResource3
{
    static bool IsCompleted { get; set; }
    static object lockCompleted = new object();
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
        lock (lockCompleted)
        {
            if (!IsCompleted)
            {
                IsCompleted = true;
                Console.WriteLine("Assalamu Alaikum!");
            }
        }
    }
}