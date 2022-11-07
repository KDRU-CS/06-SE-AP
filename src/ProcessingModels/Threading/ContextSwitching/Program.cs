// Worker Thread
Thread thread = new(LoopUsingNewThread);
thread.Name = "worker thread 01";
thread.Start();

void LoopUsingNewThread()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.Write("W " + i + " ");
    }
}

// Main thread
Thread.CurrentThread.Name = "main thread";
for (int i = 0; i < 1000; i++)
{
    Console.Write("M " + i + " ");
}