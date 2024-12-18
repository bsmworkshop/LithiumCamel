﻿namespace LithiumCamel.Shared
{
    public interface IRepository<T> : IReadRepository<T>
        where T : class
    {
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);

        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);

        Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        Task Delete(T entity, CancellationToken cancellationToken = default);

        Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken= default);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
