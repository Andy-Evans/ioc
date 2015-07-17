using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ioctest
{
    [TestClass]
    public class IocTest
    {
        [TestMethod]
        public void IocResolveTest()
        {
            var resolver = new DependencyResolver();
            resolver.Register<IFoo>(new Foo());
            resolver.Register<IBar>(new Bar());
            
            Ioc.Initialise(resolver);

            var foo = Ioc.Resolve<IFoo>();
            var bar = Ioc.Resolve<IBar>();

            Assert.IsInstanceOfType(foo, typeof(IFoo));
            Assert.IsInstanceOfType(bar, typeof(IBar));
        }
    }

    public interface IBar
    {
    }

    public class Bar : IBar
    {
    }

    public interface IFoo
    {
    }

    public class Foo : IFoo
    {
    }
}
