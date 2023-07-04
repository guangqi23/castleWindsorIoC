using System;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace codementorIOCproject
{
	public class Program
	{
		static void Main(string[] args)
		{
            var container = new WindsorContainer();

            //Register Windsor container with interface and mapped it to it implementing CompositionRoot type
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());
            //Singleton example ; Real life examples - cache, redis, database etc
            container.Register(Component.For<ISingletonDemo>().ImplementedBy<SingletonDemo>());

            /*
            Windsor looks up ICompositionRoot in its internal registry
            sees that it's mapped to CompositionRoot
            CompositionRoot -> dependency -> on IConsoleWriter.
            Repeats process for IConsoleWriter
            Creates instance of ConsoleWriter -> Creates instance of CompositionRoot
            */
            var root = container.Resolve<ICompositionRoot>();

            root.LogMessage("Proof of Windsor is working.");

            Console.ReadLine();
        }
	}
}

