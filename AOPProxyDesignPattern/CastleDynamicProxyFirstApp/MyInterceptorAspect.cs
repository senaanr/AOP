using Castle.DynamicProxy;
using Core.Interceptors;

namespace CastleDynamicProxyFirstApp
{
    public class MyInterceptorAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("before {0}", invocation.Method); // kesilen ifade
        }

        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("after {0}", invocation.Method);
        }
    }
}