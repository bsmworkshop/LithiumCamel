namespace LithiumCamel.Shared
{
    public interface IDomainEventDispatcher
    {
        Task DispatchAndClearEvents(IEnumerable<IHasDomainEvents> entitiesWithEvents);
    }
}
