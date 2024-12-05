using LithiumCamel.Shared;

namespace LithiumCamel.Application.CompetenceElements
{
    public record CreateCompetenceElementCommand(
        string Label,
        short? DefaultExpiryDays,
        short? DefaultExpiryMonths,
        short? DefaultExpiryYears,
        bool CanShortenDefaultExpiry,
        bool CanLengthenDefaultExpiry,
        bool CanNeverExpire) : ICommand<int>;
}
