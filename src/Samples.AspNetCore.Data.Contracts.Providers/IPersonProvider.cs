using Samples.AspNetCore.Data.Contracts.Dto;

namespace Samples.AspNetCore.Data.Contracts.Providers
{
    public interface IPersonProvider
    {
        PersonDto[] GetPersons();
    }
}
