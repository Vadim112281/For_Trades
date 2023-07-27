using Site_Trades.Data;
using Site_Trades.Models.RegLog;

namespace Site_Trades.Services.Trade;

public class TradeService: ITradeService
{
    private readonly AppDbContext _context;

    public TradeService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> AddTrade(Models.Trade trade)
    {
        await _context.Trades.AddAsync(trade);
        await _context.SaveChangesAsync();

        return true;
    }

    public double CountProfit()
    {
        string email = "";
        double profit = 0;

        foreach (var item in ForLogin.LogUsers)
        {
            email = item.Email;
        }

        foreach (var item in _context.Trades.Where(a => a.Email == email))
        {
            profit += item.Profit;
        }
        return profit;
    }

    public int CountTrades()
    {
        string email = "";
        int count = 0;

        foreach (var item in ForLogin.LogUsers)
        {
            email = item.Email;
        }
        
        foreach (var item in _context.Trades.Where(a => a.Email == email))
        {
            count += 1;
        }

        return count;
    }

    public int ProfitTrades()
    {
        string email = "";
        int count = 0;

        foreach (var item in ForLogin.LogUsers)
        {
            email = item.Email;
        }   
        
        foreach (var item in _context.Trades.Where(a => a.Email == email))
        {
            if (item.Profit > 0)
            {
                count += 1;
            }
        }

        return count;
    }

    public int LoseTrades()
    {
        string email = "";
        int count = 0;

        foreach (var item in ForLogin.LogUsers)
        {
            email = item.Email;
        }   
        
        foreach (var item in _context.Trades.Where(a => a.Email == email))
        {
            if (item.Profit < 0)
            {
                count += 1;
            }
        }

        return count;
    }
}