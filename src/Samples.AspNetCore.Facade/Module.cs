using Microsoft.Extensions.DependencyInjection;
using Solid.Practices.Modularity;

namespace Samples.AspNetCore.Facade
{
    class Module : ICompositionModule<IServiceCollection>
    {
        public void RegisterModule(IServiceCollection dependencyRegistrator)
        {
            dependencyRegistrator.AddCors().AddMvc();
        }
    }
}
