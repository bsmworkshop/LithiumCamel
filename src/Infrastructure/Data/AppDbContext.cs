﻿using LithiumCamel.Shared;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LithiumCamel.Infrastructure.Data
{
    public class AppDbContext(
        DbContextOptions<AppDbContext> options,
        IDomainEventDispatcher? dispatcher) : DbContext(options)
    {
        private readonly IDomainEventDispatcher? _dispatcher = dispatcher;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            if (_dispatcher == null)
                return result;

            var entitiesWithEvents = ChangeTracker.Entries<HasDomainEventsBase>()
                .Select(e => e.Entity)
                .Where(e => e.DomainEvents.Any())
                .ToArray();

            await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

            return result;
        }

        public override int SaveChanges()
            => SaveChangesAsync().GetAwaiter().GetResult();
    }
}