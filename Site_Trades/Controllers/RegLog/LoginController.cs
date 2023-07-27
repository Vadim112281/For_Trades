using Microsoft.AspNetCore.Mvc;
using Site_Trades.Data;
using Site_Trades.Models.RegLog;
using Site_Trades.Services;
using Site_Trades.ViewModels;
using System.Linq;

namespace Site_Trades.Controllers.RegLog;

public class LoginController : Controller
{
    private readonly IService _service;

    public LoginController(IService service)
    {
        _service = service;
    }
    
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(LoginViewModel user)
    {
        if(_service.GetByEmail(user) == true)
        {
            return RedirectToAction("Index", "Home");
        }

        return RedirectToAction("Index", "ErrorLog");

    }
}