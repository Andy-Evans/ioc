namespace Core
{
    public class Ioc
    {
        private static IDependencyResolver _resolver;

        public static T Resolve<T>()
        {
            return _resolver.Resolve<T>();
        }


        public static void Initialise(IDependencyResolver dependencyResolver)
        {
            _resolver = dependencyResolver;
        }
    }
}