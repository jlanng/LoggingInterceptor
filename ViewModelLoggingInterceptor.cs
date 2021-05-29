using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingInterceptor
{
    public class ViewModelLoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var property = invocation.Method.DeclaringType.GetProperties().SingleOrDefault(prop => prop.GetSetMethod() == invocation.Method);

            if (property!=null)
            {
                Console.WriteLine(property.Name + " -> " + invocation.Arguments[0]);
            }

            invocation.Proceed();
        }
    }
}
