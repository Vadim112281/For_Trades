using Site_Trades.Data;
using Site_Trades.Models.RegLog;
using Site_Trades.ViewModels;
using System.Linq;

namespace Site_Trades.Services
{
    public class Service : IService
    {
        private readonly AppDbContext _context;

        public Service(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(Register users)
        {
           await _context.Users.AddAsync(users);
           await _context.SaveChangesAsync();


           return true;
        }

        public bool GetByEmail(LoginViewModel user)
        {
            var email = user.Email;
            var password = user.Password;

            if (_context.Users.Any(u => u.Email == email))
            {
                if(_context.Users.Where(a => a.Email == email).Any(u => u.Password == password))
                {
                    ForLogin.Add(user);

                   return true;
                }
            }

            return false;
        }   
    }
}
