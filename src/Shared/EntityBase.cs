namespace LithiumCamel.Shared
{
    public abstract class EntityBase : HasDomainEventsBase
    {
        public int Id { get; protected set; }
    }

    public abstract class EntityBase<TId> : HasDomainEventsBase
        where TId : struct, IEquatable<TId>
    {
        public TId Id { get; protected set; }
    }
}
