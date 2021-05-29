using Autofac;
using LoggingInterceptor.App;
using System;

namespace LoggingInterceptor
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new ContainerBuilder();
            cb.RegisterModule<MyAppAutofacModule>();

            var c = cb.Build();

            var vm = c.Resolve<MyViewModel>();
            vm.Name = "James";
        }
    }
}
