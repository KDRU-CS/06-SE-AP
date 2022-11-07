namespace ThreadPoolDemo;

public record Employee(string FullName, string CompanyName);
public class Program
{
    public static void Main(string[] args)
    {
        var employee = new Employee("Ahmad Wali", "Afghan Maldaar");
        ThreadPool.QueueUserWorkItem(new WaitCallback(DisplayEmployeeInfo), employee);
        
        var processorCount = Environment.ProcessorCount;
        Console.WriteLine(processorCount);
        
        Console.ReadKey();
    }

    public static void DisplayEmployeeInfo(object state)
    {
        Console.WriteLine($"ThreadPool: {Thread.CurrentThread.IsThreadPoolThread}");
        var employee = state as Employee;
        Console.WriteLine(employee?.FullName + " is employee at " + employee?.CompanyName);
    }
}