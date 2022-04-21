using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPwithDynamicProxy.Aspects
{
    public class Logging : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"{invocation.Method.Name} isimli metot, paramatreleri: {string.Join("-",invocation.Arguments.Select(x=>x?.ToString()).ToArray())} ");

            invocation.Proceed();
            Console.WriteLine($"{invocation.Method.Name} Metodunun çalışması tamamlandı");
        }

    }
}
