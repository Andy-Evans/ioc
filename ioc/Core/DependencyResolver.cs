using System;
using System.Collections.Generic;

namespace Core
{
    public class DependencyResolver : IDependencyResolver
    {
        private readonly IDictionary<Type,object> _registeredTypes = new Dictionary<Type, object>();
        public void Register<T>(T obj)
        {
            _registeredTypes.Add(typeof(T), obj);
        }

        public T Resolve<T>()
        {
            return (T) _registeredTypes[typeof (T)];
        }
    }
}