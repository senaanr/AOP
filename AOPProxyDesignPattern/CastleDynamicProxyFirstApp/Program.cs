using Castle.DynamicProxy;

namespace CastleDynamicProxyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // runtimeda proxy tanımlamaya olanak kılar
            // proxy nesnelerinin kodunu değiştirmeden bir nesnenin üyeleri üstünde çağrı yapmayı sağlar
            // hem sınıflar hem arayüzler proxylenebilir
            var proxy = new ProxyGenerator(); //sınıfı bir bütün olarak sarmallar
            var aspect = proxy
                .CreateClassProxy<MyClass>(new MyInterceptorAspect());

            aspect.MyMethod();
            //method çalışırken araya girdik
        }
    }
}