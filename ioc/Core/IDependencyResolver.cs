namespace Core
{
    public interface IDependencyResolver
    {
        T Resolve<T>();
    }
}