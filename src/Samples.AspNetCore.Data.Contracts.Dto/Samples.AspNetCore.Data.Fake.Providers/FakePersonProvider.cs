using Attest.Fake.Builders;
using Samples.AspNetCore.Data.Contracts.Dto;
using Samples.AspNetCore.Data.Contracts.Providers;
using Samples.AspNetCore.Data.Fake.ProviderBuilders;

namespace Samples.AspNetCore.Data.Fake.Providers
{
    class FakePersonProvider : FakeProviderBase<PersonProviderBuilder, IPersonProvider>, IPersonProvider
    {
        private readonly PersonProviderBuilder _personProviderBuilder;

        public FakePersonProvider(
            PersonProviderBuilder personProviderBuilder)
        {
            _personProviderBuilder = personProviderBuilder;
            _personProviderBuilder.WithPersons(new [] { new PersonDto {
                    FirstName = "John",
                    LastName = "Doe"
                }});
        }

        PersonDto[] IPersonProvider.GetPersons()
        {
            var service = GetService(() => _personProviderBuilder, b => b);
            return service.GetPersons();
        }
    }
}
