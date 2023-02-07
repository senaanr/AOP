using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspects;

namespace InvocationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy
                .CreateClassProxy<Employee>(
                new InterceptionAspect(),
                new DefensiveProgrammingAspect());

            var emp1 = new Employee()
            {
                Id = 1,
                FirstName = "Mert",
                LastName = "Gülle"
            };

            aspect.Add(emp1.Id, emp1.FirstName, emp1.LastName);
        }
    }
}