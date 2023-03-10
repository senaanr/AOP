using Castle.DynamicProxy;

namespace InvocationApp.Aspects
{
    public class DefensiveProgrammingAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var parameters = invocation.Arguments;
            foreach (var p in parameters)
            {
                if (p.Equals(null))
                    throw new ArgumentNullException();
            }
            Console.WriteLine("null check has been completed for {0}", invocation.Method);
        }
    }
}
