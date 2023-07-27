using Microsoft.AspNetCore.Mvc;

namespace Site_Trades.Controllers;

public class EnterController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}