using System.Reflection;


var lib = Assembly.LoadFrom("MyLibrary.dll");
foreach (var type in lib.GetTypes())
{
    if (type.IsClass)
    {

        Console.WriteLine(type.FullName);
        Console.ReadLine();
    }
}

foreach (Type ty in lib.GetTypes().Where(x => x.IsClass))
{
    if (ty.Name == "Foo")
    {
        var instance = Activator.CreateInstance(ty);
        foreach (MethodInfo methodInfo in ty.GetMethods())
        {
            if (methodInfo.Name.StartsWith("My")) { methodInfo.Invoke(instance, null); }
        }
    }

    if (ty.Name == "FooWithParameters")
    {
        var instance = Activator.CreateInstance(ty);
        foreach (MethodInfo methodInfo in ty.GetMethods())
        {
            if (methodInfo.Name.StartsWith("WithParameters")) { methodInfo.Invoke(instance, new object[] { "Testing With parameters" }); }
        }
    }
}


