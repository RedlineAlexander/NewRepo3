using NewRepo3.DependencyInjectionExampleKukhar;
using System;
using Unity;

namespace NewRepo3
{
    class Program
    {
        static void Main(string[] args)
        {

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IFortuneLoader, KukharFortuneLoader>();
            container.RegisterType<IFortuneTeller, KukharFortuneTelletr>();
            container.RegisterType<IFortuneGetter, KukharFortuneGetter>();
            container.RegisterType<IFortuneFacade, KukharFortuneFacade>();


            var fortuneFacade = container.Resolve<IFortuneFacade>();
            fortuneFacade.FortuneFacade();
            //  IUnityContainer container = new UnityContainer();
            // container.RegisterType<IFortuneLoader, >();
            //container.RegisterType<IFortuneTeller, >();
            // var fortuneTeller = container.Resolve<IFortuneTeller>();
            // fortuneTeller.TellFortune();
            Console.WriteLine("Hello World!");
            Console.Read();
            Console.WriteLine("Hello World!");
        }
    }
}
