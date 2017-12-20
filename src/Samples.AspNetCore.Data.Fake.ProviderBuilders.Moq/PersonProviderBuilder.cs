using System.Collections.Generic;
using Attest.Fake.Setup.Contracts;
using LogoFX.Client.Data.Fake.ProviderBuilders;
using Samples.AspNetCore.Data.Contracts.Dto;
using Samples.AspNetCore.Data.Contracts.Providers;

namespace Samples.AspNetCore.Data.Fake.ProviderBuilders
{
    public class PersonProviderBuilder : FakeBuilderBase<IPersonProvider>
    {
        private readonly List<PersonDto> _persons = new List<PersonDto>();

        public static PersonProviderBuilder CreateBuilder()
        {
            return new PersonProviderBuilder();
        }

        protected override IServiceCall<IPersonProvider>
            CreateServiceCall(IHaveNoMethods<IPersonProvider> serviceCallTemplate)
        {
            var setup = serviceCallTemplate
                .AddMethodCallWithResult(
                    t => t.GetPersons(),
                    r => r.Complete(_persons.ToArray()));
            return setup;
        }

        public void WithPersons(IEnumerable<PersonDto> persons)
        {
            _persons.Clear();
            _persons.AddRange(persons);
        }
    }
}
