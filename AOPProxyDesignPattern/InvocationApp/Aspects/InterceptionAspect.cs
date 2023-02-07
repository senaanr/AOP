using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocationApp.Aspects
{
    public class InterceptionAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("before {0}", invocation.Method);
            Console.WriteLine($"{"MethodName",-20} : {invocation.Method.Name}");
            Console.WriteLine($"{"TargetType",-20} : {invocation.TargetType}");
            Console.WriteLine($"{"InvocationTarget",-20} : {invocation.InvocationTarget}");
            Console.WriteLine($"{"Proxy",-20} : {invocation.Proxy}");
            Console.WriteLine("arguments");

            foreach (var p in invocation.Arguments)
            {
                Console.WriteLine($"\t{"Type",-12} : {p.GetType(),-15} | {p}");
            }
            Console.WriteLine();
            invocation.Proceed();
            Console.WriteLine("after  {0}", invocation.Method);
        }
    }
}
