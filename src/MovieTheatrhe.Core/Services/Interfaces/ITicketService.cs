using MovieTheatre.Core.Models;
using System.Linq.Expressions;

namespace MovieTheatre.Core.Services.Interfaces
{
    public interface ITicketService
    {
        Task<List<Ticket>> GetAllAsync();

        Task<Ticket> GetAsync(int id);

        Task<Ticket> AddAsync(Ticket entity);

        Task<Ticket> UpdateAsync(Ticket entity);

        Task<Ticket> DeleteAsync(int id);

        Task<IEnumerable<Ticket>> Find(Expression<Func<Ticket, bool>> predicate);

        Task<List<Ticket>> GetAllSoldAsync();
    }
}
