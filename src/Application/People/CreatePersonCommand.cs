using LithiumCamel.Shared;

namespace LithiumCamel.Application.People
{
    public record CreatePersonCommand(string FamilyName, string GivenName, string? OtherNames) : ICommand<int>;
}
