using Microsoft.AspNetCore.Mvc;

namespace Site_Trades.Controllers.RegLog;

public class ErrorLogController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}