using Microsoft.AspNetCore.Mvc;
using MovieTheatre.Core.Services.Interfaces;

namespace MovieTheatre.MVC.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public IActionResult Index()
        {
            var tickets = _ticketService.GetAllSoldAsync();
            return View(tickets);
        }
    }
}
