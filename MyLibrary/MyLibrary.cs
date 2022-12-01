using System.Runtime.CompilerServices;
using MyAttribute;
namespace MyLibrary
{
    public class Foo
    {
        [ExecuteMe( "Hello! ")]
        [ExecuteMe("How ")]
        [ExecuteMe( "Are ")]
        [ExecuteMe( "You?")]
        public void MyPrint() { Console.WriteLine("This Is MyPrint!"); }

        [ExecuteMe("Let's try ") , ExecuteMe("Adding more!")]
        public void MyPrintWithMoreAttributes() { Console.WriteLine("Yes, more attributes works!");}

        [ExecuteMe("What about ints?"), ExecuteMe(12), ExecuteMe(13)]
        public void MyPrintWithMultipleTypes() { Console.WriteLine("They can even be int!");}

        [ExecuteMe("Various Methods")]
        public void MyPrintX1() {Console.WriteLine("Now i try more calls");}
        public void MyPrintX2() {Console.WriteLine("Works fine!");}
    }

}