﻿using Microsoft.Extensions.Logging;
using MovieTheatrhe.Core.Data;
using MovieTheatrhe.Core.Repositories.Interfaces;

namespace MovieTheatrhe.Core.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        public IFoodRepository FoodRepository { get; private set; }

        public UnitOfWork(AppDbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}