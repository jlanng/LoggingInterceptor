using Autofac;
using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingInterceptor.App
{
    class MyAppAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(new ViewModelLoggingInterceptor());

            builder.RegisterType<MyViewModel>()
                .EnableClassInterceptors();
        }
    }
}
