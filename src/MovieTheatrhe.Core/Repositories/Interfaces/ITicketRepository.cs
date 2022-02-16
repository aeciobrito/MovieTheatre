using MovieTheatre.Core.Models;

namespace MovieTheatre.Core.Repositories.Interfaces
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        Task<List<Ticket>> GetAllSoldAsync();
    }
}
