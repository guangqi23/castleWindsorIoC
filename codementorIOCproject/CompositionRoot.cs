using System;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace codementorIOCproject
{
	public class CompositionRoot : ICompositionRoot
	{
		// Composition Root contain other application logic
		public CompositionRoot()
		{
			var container = new WindsorContainer();

			//Register Windsor container with interface and mapped it to it implementing CompositionRoot type
			container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());

			//Initialising Windsor Container to give an insance of ICompositionRoot
			var root = container.Resolve<ICompositionRoot>();

			Console.ReadLine();

		}
	}
}

