using Microsoft.Extensions.Logging;
using MovieTheatre.Core.Data;
using MovieTheatre.Core.Repositories;
using MovieTheatre.Core.Repositories.Interfaces;

namespace MovieTheatre.Core.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;
        //private readonly ILogger _logger;

        public IFoodRepository FoodRepository { get; private set; }
        public ITicketRepository TicketRepository { get; private set; }

        public UnitOfWork(AppDbContext context, ILogger logger)
        {
            _context = context;
            //_logger = logger;

            FoodRepository = new FoodRepository(context);
            TicketRepository = new TicketRepository(context);
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
