namespace ProxyApp
{
    public interface IBusinessModule
    {
        void Method();
    }

    public class BusinessModule : IBusinessModule
    {
        public void Method()
        {
            Console.WriteLine("method..");
        }
    }

    public class BusinessModuleProxy : IBusinessModule
    {
        private BusinessModule _realObject;
        public BusinessModuleProxy()
        {
            _realObject = new BusinessModule();
        }

        public void Method()
        {
            Console.WriteLine("before method.");
            _realObject.Method(); // her türlü değişiklik doğrudan buraya yansır
            Console.WriteLine("after method.");
        }
        // proxy bize ne sağladı?
        // gerçek objede(business module methodu) üstünde yapacağımız herhangi
        // bir değişiklik Proxyi etkilemeyecek. Proxy newlemesini yapacak.
        // Ve çağıracak. İstenen methodun öncesinde veya sonrasında 
        // bir takım kodlar çalıştırma imkanını bize sundu.
        // tekrar tekrar bakım yapmaya gerek yok.
    }

    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}