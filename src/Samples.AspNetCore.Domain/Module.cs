using Microsoft.Extensions.DependencyInjection;
using Samples.AspNetCore.Domain.Services;
using Solid.Practices.Modularity;

namespace Samples.AspNetCore.Domain
{
    public class Module : ICompositionModule<IServiceCollection>
    {
        public void RegisterModule(IServiceCollection dependencyRegistrator)
        {
            dependencyRegistrator.AddSingleton<IPersonService, PersonService>();
        }
    }
}
