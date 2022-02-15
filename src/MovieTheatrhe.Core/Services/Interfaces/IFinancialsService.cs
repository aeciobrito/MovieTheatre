using MovieTheatrhe.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatrhe.Core.Services.Interfaces
{
    public interface IFinancialsService
    {
        public decimal GetTotalSold();
        public FinancialStats GetStats();
    }
}
