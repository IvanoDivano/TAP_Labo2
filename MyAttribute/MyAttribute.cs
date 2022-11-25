namespace MyAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)] public sealed class ExecuteMeAttribute : Attribute
    {
        public string command { get; }
        public string arguments { get; }

        public string phraseToPrint { get; }

        public ExecuteMeAttribute(string command, string arguments)
        {
            this.command = command;
            this.arguments = arguments;
        }

        public ExecuteMeAttribute(string phrase)
        {
            this.phraseToPrint = phrase;
        }
    }
}