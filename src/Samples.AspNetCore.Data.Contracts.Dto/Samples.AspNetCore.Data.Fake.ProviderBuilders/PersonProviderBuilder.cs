using System.Collections.Generic;
using Attest.Fake.Builders;
using Attest.Fake.LightMock;
using Attest.Fake.Setup;
using LightMock;
using Samples.AspNetCore.Data.Contracts.Dto;
using Samples.AspNetCore.Data.Contracts.Providers;

namespace Samples.AspNetCore.Data.Fake.ProviderBuilders
{
    public class PersonProviderBuilder : FakeBuilderBase<IPersonProvider>
    {
        class PersonProviderProxy : ProviderProxyBase<IPersonProvider>, IPersonProvider
        {
            public PersonProviderProxy(IInvocationContext<IPersonProvider> context)
                : base(context)
            {
            }

            public PersonDto[] GetPersons()
            {
                return Invoke(t => t.GetPersons());
            }
        }

        private readonly List<PersonDto> _personsStorage = new List<PersonDto>();

        private PersonProviderBuilder() :
            base(FakeFactoryHelper.CreateFake<IPersonProvider>(c => new PersonProviderProxy(c)))
        {

        }

        public static PersonProviderBuilder CreateBuilder() => new PersonProviderBuilder();

        public void WithPersons(IEnumerable<PersonDto> persons)
        {
            _personsStorage.Clear();
            _personsStorage.AddRange(persons);
        }

        protected override void SetupFake()
        {
            var initialSetup = ServiceCallFactory.CreateServiceCall(FakeService);

            var setup = initialSetup
                .AddMethodCallWithResult(t => t.GetPersons(),
                                              r => r.Complete(GetPersons));

            setup.Build();
        }

        private PersonDto[] GetPersons()
        {
            return _personsStorage.ToArray();
        }
    }
}
