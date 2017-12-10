using System.IO;
using LogoFX.Server.Bootstrapping;
using Microsoft.Extensions.DependencyInjection;

namespace Samples.AspNetCore.Facade
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper(IServiceCollection dependencyRegistrator) : base(dependencyRegistrator)
        {
        }

        public override string ModulesPath =>

#if DEBUGWITHFAKE
        Path.Combine(new []{"..","bin","DebugWithFake", "netcoreapp2.0"})
#elif DEBUGWITHREAL
        Path.Combine(new []{"..","bin","DebugWithReal", "netcoreapp2.0"})
#elif RELEASE
            "."
#else
        Path.Combine(new []{"..","bin","Debug", "netcoreapp2.0"})
#endif
        ;

        public override string[] Prefixes => new string[] { };
    }
}
