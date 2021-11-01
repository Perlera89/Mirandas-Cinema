﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.Base
{
    public class EntityRepository<T> : IEntity<T> where T : class, IBase, new()
    {
        private readonly AppDbContext context;

        public EntityRepository(AppDbContext _context)
        {
            context = _context;
        }

        public async Task Add(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
            EntityEntry entityEntry = context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var entities = await context.Set<T>().ToListAsync();
            return entities;
        }

        public async Task<T> GetById(int id)
        {
            var entities = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
            return entities;
        }

        public async Task Update(int id, T entity)
        {
            EntityEntry entityEntry = context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await context.SaveChangesAsync();
        }
    }
}