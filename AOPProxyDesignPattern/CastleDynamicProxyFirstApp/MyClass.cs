namespace CastleDynamicProxyFirstApp
{
    public class MyClass
    {
        [MyInterceptorAspect]
        public virtual void MyMethod()
        {
            Console.WriteLine("my method body.");
        }
    }
}