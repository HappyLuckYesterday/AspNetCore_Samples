using Microsoft.Extensions.DependencyInjection;
using Samples.AspNetCore.Data.Contracts.Providers;
using Solid.Practices.Modularity;

namespace Samples.AspNetCore.Data.Real.Providers
{
    class Module : ICompositionModule<IServiceCollection>
    {
        public void RegisterModule(IServiceCollection dependencyRegistrator)
        {
            dependencyRegistrator.AddSingleton<IPersonProvider, PersonProvider>();
        }
    }
}
