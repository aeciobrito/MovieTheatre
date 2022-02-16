using Microsoft.EntityFrameworkCore;
using MovieTheatre.Core.Data;
using MovieTheatre.Core.Models;
using MovieTheatre.Core.Repositories.Interfaces;

namespace MovieTheatre.Core.Repositories
{
    public class TicketRepository : Repository<Ticket, AppDbContext>, ITicketRepository
    {
        public TicketRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Ticket>> GetAllSoldAsync()
            => await _context.Tickets.ToListAsync();        
    }
}
