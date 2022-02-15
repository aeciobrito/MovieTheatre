using Microsoft.EntityFrameworkCore;
using MovieTheatrhe.Core.Data;
using MovieTheatrhe.Core.Models;
using MovieTheatrhe.Core.Repositories.Interfaces;

namespace MovieTheatrhe.Core.Repositories
{
    internal class TicketRepository : Repository<Ticket, AppDbContext>, ITicketRepository
    {
        public TicketRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Ticket>> GetAllSold()
            => await _context.Tickets.ToListAsync();        
    }
}
