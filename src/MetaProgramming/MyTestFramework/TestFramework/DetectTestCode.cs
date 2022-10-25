using System.Reflection;

namespace MyTestFramework.TestFramework;

public class DetectTestCode
{
    public static void ExecuteTestMethods()
    {
        var testSuites =
            from t in Assembly.GetExecutingAssembly().GetTypes()
            where t.GetCustomAttributes(false).Any(x => x is TestClassAttribute)
            select t;


        foreach (Type t in testSuites)
        {
            var testMethods =
            from m in t.GetMethods()
            where m.GetCustomAttributes(false).Any(x => x is TestMethodAttribute)
            select m;

#nullable disable
            object testSuiteInstance = Activator.CreateInstance(t);
#nullable enable

            foreach (MethodInfo item in testMethods)
            {
                item.Invoke(testSuiteInstance, new object[0]);
            }
        }
    }
}