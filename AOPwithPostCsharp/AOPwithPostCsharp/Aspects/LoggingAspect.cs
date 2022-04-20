using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPwithPostCsharp.Aspects
{
    [PSerializable]
    public class LoggingAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name} isimli, {string.Join(",",args.Arguments)} parametreli metoda giriş yapıldı");
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name} başarıyla çalıştı");            
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name} metodundan çıkıldı");

        }
        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name} metodu hata verdi");
        }



    }
}
