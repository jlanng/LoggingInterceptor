using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingInterceptor.App
{
    [Intercept(typeof(ViewModelLoggingInterceptor))]
    public class MyViewModel
    {
        public virtual string Name { get; set; }
    }
}
