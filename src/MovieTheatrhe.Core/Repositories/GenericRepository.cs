﻿using Microsoft.EntityFrameworkCore;
using MovieTheatrhe.Core.Data;
using MovieTheatrhe.Core.Models.Interfaces;
using MovieTheatrhe.Core.Repositories.Interfaces;
using System.Linq.Expressions;

namespace MovieTheatrhe.Core.Repositories
{
    public abstract class GenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : AppDbContext
    {
        public readonly TContext _context;
        public readonly DbSet<TEntity> _entities;

        protected GenericRepository(TContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAllAsync() => await _entities.ToListAsync();

        public async Task<TEntity> GetAsync(int id) => await _entities.FindAsync(id);

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);

            if (entity == null) return entity;

            _context.Set<TEntity>().Remove(entity);            
            await _context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }
    }
}
