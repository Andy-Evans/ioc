using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ioctest
{
    [TestClass]
    public class DependencyResolverTest
    {
        [TestMethod]
        public void CanRegisterDependency()
        {
            var resolver = new DependencyResolver();
            resolver.Register<IFoo>(new Foo());

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void CanResolveDependency()
        {
            var resolver = new DependencyResolver();

            resolver.Register<IFoo>(new Foo());
            var foo = resolver.Resolve<IFoo>();

            Assert.IsInstanceOfType(foo, typeof(Foo));
        }
    }
}
