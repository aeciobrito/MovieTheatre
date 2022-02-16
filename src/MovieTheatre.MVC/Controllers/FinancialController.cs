using Microsoft.AspNetCore.Mvc;
using MovieTheatre.Core.Services.Interfaces;

namespace MovieTheatre.MVC.Controllers
{
    public class FinancialController : Controller
    {
        private readonly IFinancialsService _financialService;

        public FinancialController(IFinancialsService financialService)
        {
            _financialService = financialService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
