using System.Reflection;

var lib = Assembly.LoadFrom("C:\\Users\\tenga\\source\\repos\\TAP_Labo2\\MyLibrary\\bin\\Release\\net6.0\\MyLibrary.dll");
foreach (var type in lib.GetTypes())
{
    if (type.IsClass)
    {

        Console.WriteLine(type.FullName);
        Console.ReadLine();
    }
}