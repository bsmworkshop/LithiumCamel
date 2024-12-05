using MediatR;

namespace LithiumCamel.Shared
{
    public abstract class DomainEventBase : INotification
    {
        public DateTime DateOccured { get; protected set; } = DateTime.UtcNow;
    }
}