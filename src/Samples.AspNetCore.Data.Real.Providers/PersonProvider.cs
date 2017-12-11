using Samples.AspNetCore.Data.Contracts.Dto;
using Samples.AspNetCore.Data.Contracts.Providers;

namespace Samples.AspNetCore.Data.Real.Providers
{
    class PersonProvider : IPersonProvider
    {
        PersonDto[] IPersonProvider.GetPersons()
        {
            return new PersonDto[]
            {
                new PersonDto
                {
                    FirstName = "Real Name",
                    LastName = "Real Surname"
                }
            };
        }
    }
}
