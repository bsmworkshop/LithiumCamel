namespace LithiumCamel.Shared
{
    public abstract class EntityWithAuditingBase<TId> : EntityBase<TId>
        where TId : struct, IEquatable<TId>
    {
        public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow;
        public int CreatedById { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }
        public int? UpdatedById { get; protected set; }
        public DateTime? DeletedAt { get; protected set; }
        public int? DeletedById { get; protected set; }
    }

    public abstract class EntityWithAuditingBase : EntityWithAuditingBase<int>
    {
    }
}
