namespace SharedResources;

// run 100 or more times, it will happen that it prints the line twice.
// for ($i=1; $i -le 100; $i++) {dotnet run; echo "end"}
public static class SharedResource2
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
            IsCompleted = true;
            Console.WriteLine("Assalamu Alaikum!");
        }
    }
}