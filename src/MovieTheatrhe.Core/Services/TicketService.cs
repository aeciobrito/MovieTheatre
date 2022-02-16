using MovieTheatre.Core.Models;
using MovieTheatre.Core.Repositories.Interfaces;
using MovieTheatre.Core.Services.Interfaces;
using System.Linq.Expressions;

namespace MovieTheatre.Core.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepo;

        public TicketService(ITicketRepository ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }

        public Task<Ticket> AddAsync(Ticket entity)
        {
            //validation
            return _ticketRepo.AddAsync(entity);
        }

        public async Task<Ticket> DeleteAsync(int id)
        {
            //validation
            return await _ticketRepo.DeleteAsync(id);
        }

        public async Task<IEnumerable<Ticket>> Find(Expression<Func<Ticket, bool>> predicate)
        {
            //validation
            return await _ticketRepo.Find(predicate);
        }

        public async Task<List<Ticket>> GetAllAsync()
        {
            //validation
            return await _ticketRepo.GetAllAsync();
        }

        public async Task<List<Ticket>> GetAllSoldAsync()
        {
            //validation
            return await _ticketRepo.GetAllSoldAsync();
        }

        public async Task<Ticket> GetAsync(int id)
        {
            //validation
            return await _ticketRepo.GetAsync(id);
        }

        public async Task<Ticket> UpdateAsync(Ticket entity)
        {
            //validation
            return await _ticketRepo.UpdateAsync(entity);
        }
    }
}
