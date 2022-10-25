using System.Reflection;

namespace MyJsonLibrary.JsonUtils;

public class JsonSerializer<T>
{
    public string SerializeObject(T json)
    {
        if(json is null)
            throw new Exception("No data in the model.");

        Type type = json.GetType();

        string result = "";

        var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        var last = properties.Last();

        result += "{";
        foreach (var item in properties)
        {
            result += item.Name;
            result += ": ";
            result += item.GetValue(json);
            if(!item.Equals(last)) 
                result += ", ";
        }
        result += "}";

        return result;
    }
}