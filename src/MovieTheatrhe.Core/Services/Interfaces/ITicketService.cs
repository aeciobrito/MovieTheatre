using MovieTheatrhe.Core.Models;

namespace MovieTheatrhe.Core.Services.Interfaces
{
    public interface ITicketService
    {
        Task<List<Ticket>> GetAllAsync();

        Task<Ticket> GetAsync(int id);

        Task<Ticket> AddAsync(Ticket entity);

        Task<Ticket> UpdateAsync(Ticket entity);

        Task<Ticket> DeleteAsync(int id);

        Task<IEnumerable<Ticket>> Find();

        Task<List<Ticket>> GetAllSold();
    }
}
