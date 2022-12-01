using System;

namespace MyAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)] public sealed class ExecuteMeAttribute : Attribute
    {
        public object MyAttributeArguments { get; }

        public ExecuteMeAttribute(object arg)
        {
            this.MyAttributeArguments = arg;
        }


    }
}