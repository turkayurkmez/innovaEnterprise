using AOPwithPostCsharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPwithPostCsharp
{
    public class Example
    {
        [LoggingAspect]
        public void BirMetot()
        {
            Console.WriteLine("Hello, World!");
        }

        [LoggingAspect]
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
