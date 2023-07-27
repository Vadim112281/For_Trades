using Microsoft.AspNetCore.Mvc;
using Site_Trades.Models.RegLog;
using Site_Trades.Services;

namespace Site_Trades.Controllers.RegLog
{
    public class RegisterController : Controller
    {
        private readonly IService _service;

        public RegisterController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Register user)
        {
            user.IsRegisted= true;
            await _service.Add(user);

            return RedirectToAction("Index", "Login");
        }
    }
}
