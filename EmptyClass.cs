using System;
using Internal;

namespace Application
{
	public class Program
	{
		static void Main(string[] args)
		{
            var container = new WindsorContainer();

            //Register Windsor container with interface and mapped it to it implementing CompositionRoot type
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());

            //Initialising Windsor Container to give an instance of ICompositionRoot
            var root = container.Resolve<ICompositionRoot>();
            root.LogMessage("Proof of Windsor is working.");

            Console.ReadLine();
        }
	}
}

