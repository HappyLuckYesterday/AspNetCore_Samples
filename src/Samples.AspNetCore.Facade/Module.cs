using System;
using Microsoft.Extensions.DependencyInjection;
using Solid.Practices.Modularity;

namespace HelloAspNetCoreMac
{
    class Module : ICompositionModule<IServiceCollection>
    {
        public void RegisterModule(IServiceCollection dependencyRegistrator)
        {
            dependencyRegistrator.AddCors().AddMvc();
        }
    }
}
