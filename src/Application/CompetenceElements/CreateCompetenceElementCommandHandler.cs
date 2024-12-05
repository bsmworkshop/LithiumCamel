using LithiumCamel.Domain.Entities;
using LithiumCamel.Shared;

namespace LithiumCamel.Application.CompetenceElements
{
    public class CreateCompetenceElementCommandHandler(IRepository<CompetenceElement> repository)
        : ICommandHandler<CreateCompetenceElementCommand, int>
    {
        private IRepository<CompetenceElement> _repository = repository;

        public async Task<int> Handle(CreateCompetenceElementCommand request, CancellationToken cancellationToken)
        {
            var competenceElement = CompetenceElement.Create(
                request.Label,
                request.DefaultExpiryDays,
                request.DefaultExpiryMonths,
                request.DefaultExpiryYears,
                request.CanShortenDefaultExpiry,
                request.CanLengthenDefaultExpiry,
                request.CanNeverExpire);

            var created = await _repository.AddAsync(competenceElement, cancellationToken);

            return created.Id;
        }
    }
}
