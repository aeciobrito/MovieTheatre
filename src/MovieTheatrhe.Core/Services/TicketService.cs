using MovieTheatrhe.Core.Models;
using MovieTheatrhe.Core.Services.Interfaces;

namespace MovieTheatrhe.Core.Services
{
    public class TicketService : ITicketService
    {
        public Task<Ticket> AddAsync(Ticket entity)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> Find()
        {
            throw new NotImplementedException();
        }

        public Task<List<Ticket>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Ticket>> GetAllSold()
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> UpdateAsync(Ticket entity)
        {
            throw new NotImplementedException();
        }
    }
}
