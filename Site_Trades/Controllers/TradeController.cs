using Microsoft.AspNetCore.Mvc;
using Site_Trades.Models;
using Site_Trades.Models.RegLog;
using Site_Trades.Services.Trade;

namespace Site_Trades.Controllers
{
    public class TradeController : Controller
    {
        private ITradeService _service;

        public TradeController(ITradeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Trade trade)
        {
            
            
            //if (!ModelState.IsValid)
            //{
            //    return View(trade);
            //}
            string email = "";

            foreach (var item in ForLogin.LogUsers)
            {
                email = item.Email;
            }


            trade.Email = email;
            await _service.AddTrade(trade);
            
            
            return RedirectToAction("Index", "Home");
        }
    }
}
