using Microsoft.Extensions.DependencyInjection;
using Samples.AspNetCore.Data.Contracts.Providers;
using Solid.Practices.Modularity;

namespace Samples.AspNetCore.Data.Fake.Providers
{
    public class Module : ICompositionModule<IServiceCollection>
    {
        public void RegisterModule(IServiceCollection dependencyRegistrator)
        {
            dependencyRegistrator.AddSingleton<IPersonProvider, FakePersonProvider>();
        }
    }
}
