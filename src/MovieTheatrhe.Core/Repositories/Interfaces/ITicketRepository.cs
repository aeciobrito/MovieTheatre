using MovieTheatrhe.Core.Models;

namespace MovieTheatrhe.Core.Repositories.Interfaces
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        Task<List<Ticket>> GetAllSold();
    }
}
