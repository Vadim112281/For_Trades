namespace Site_Trades.Services.Trade;

public interface ITradeService
{
    Task<bool> AddTrade(Models.Trade trade);

    double CountProfit();

    int CountTrades();

    int ProfitTrades();

    int LoseTrades();
}