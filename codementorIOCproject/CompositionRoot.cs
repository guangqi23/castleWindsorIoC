using System;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace codementorIOCproject
{
	public class CompositionRoot : ICompositionRoot
	{
        readonly IConsoleWriter consoleWriter;
        readonly ISingletonDemo singletonDemo;

        public CompositionRoot(IConsoleWriter consoleWriter, ISingletonDemo singletonDemo)
        {
            this.consoleWriter = consoleWriter;
            this.singletonDemo = singletonDemo;
            consoleWriter.LogMessage("Hello from CompositionRoot constructor");
        }

		// Composition Root contain other application logic
        public void LogMessage(string message)
        {
            var msg = $"CompositionRoot.LogMessage : singletonDemo.ObjectId={singletonDemo.ObjectId}";
            consoleWriter.LogMessage(msg);
			Console.WriteLine(message);
        }
    }
}

