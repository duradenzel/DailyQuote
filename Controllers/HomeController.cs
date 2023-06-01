using DailyQuote.Models;
using Logic;
using Logic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DailyQuote.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly QuoteService _quoteService = new();
        public IActionResult Index()
        {
            Quote q = _quoteService.GetQuote();
            return View(q);
        }

       

    }
}