using MyAttribute;
namespace MyLibrary
{
    public class Foo
    {
        [ExecuteMe( "Hello! ")]
        [ExecuteMe("How ")]
        [ExecuteMe( "Are ")]
        [ExecuteMe( "You?")]
        public void MyPrint(string msg)
        {
            Console.Write(msg);
        }

        [ExecuteMe("get", "sum")]
        public void MySum(int n1, int n2)
        {
            Console.WriteLine(n1+n2);
        }

        [ExecuteMe("get", "diff")]
        public void MySub(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
    }

}