namespace CodeFirstContextRequest.Web.Dependencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using StructureMap;
    using System.Web.Mvc;

    public class StructureMapDependencyResolver:IDependencyResolver
    {
        public StructureMapDependencyResolver(IContainer container)
        {
            this.container = container;
        }

        private readonly IContainer container;

        public object GetService(Type serviceType)
        {
            if (serviceType.IsAbstract || serviceType.IsInterface)
            {
                object truInstance = this.container.TryGetInstance(serviceType);
                return truInstance;
            }

            object instance = this.container.GetInstance(serviceType);
            return instance;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return container.GetAllInstances<object>()
                .Where(s => s.GetType() == serviceType);
        }
    }
}