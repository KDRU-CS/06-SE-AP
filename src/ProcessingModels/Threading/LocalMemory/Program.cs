// Worker thread
new Thread(PrintValuesFrom1To100).Start();

// Main thread
PrintValuesFrom1To100();

void PrintValuesFrom1To100()
{
    for(int i = 0; i < 100; i++)
    {
        Console.Write(i + 1 + " ");
    }
}