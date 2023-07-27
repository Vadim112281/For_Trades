using Microsoft.AspNetCore.Mvc;
using Site_Trades.Models.RegLog;
using Site_Trades.Services.Trade;

namespace Site_Trades.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ITradeService _service;

        public ProfileController(ITradeService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            ForLogin.Profit.Add(_service.CountProfit());
            ForLogin.CountTrades.Add(_service.CountTrades());
            ForLogin.ProfitTrades.Add(_service.ProfitTrades());
            ForLogin.LoseTrades.Add(_service.LoseTrades());
            
            return View();
        }
    }
}



//Створити нову табличку в базі даних, де буде тільки ім'я + фаміля + емаіл і все, по кнопці регестрація і туди додавати ті значення,
// а потім вже витягувати саме з цієї таблички значення, які на потрібні