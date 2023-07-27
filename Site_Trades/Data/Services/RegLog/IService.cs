using Site_Trades.Models.RegLog;
using Site_Trades.ViewModels;

namespace Site_Trades.Services
{
    public interface IService
    {
        Task<bool> Add(Register users);

        bool GetByEmail(LoginViewModel user);

    }
}
