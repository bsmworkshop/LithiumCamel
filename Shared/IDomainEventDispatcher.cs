namespace LithiumCamel.Shared
{
    public interface IDomainEventDispatcher
    {
        Task DispatchAndClearEventsAsync(IEnumerable<IHasDomainEvents> entitiesWithEvents);
    }
}
