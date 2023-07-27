using Microsoft.AspNetCore.Mvc;
using Site_Trades.Models.RegLog;

namespace Site_Trades.Controllers.RegLog;

public class LogOutController : Controller
{
    // GET
    public IActionResult Index()
    {
        ForLogin.LogUsers.Clear();
        ForLogin.CountTrades.Clear();
        ForLogin.Profit.Clear();
        ForLogin.LoseTrades.Clear();
        ForLogin.ProfitTrades.Clear();
        
        
        return RedirectToAction("Index", "Login");
    }
}