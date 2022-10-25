using MyJsonLibrary;
using MyJsonLibrary.JsonUtils;

Person p = new()
{
    FirstName = "Ahmad",
    LastName = "Khan",
    Grade = 12
};

JsonSerializer<Person> js = new();
Console.WriteLine(js.SerializeObject(p));