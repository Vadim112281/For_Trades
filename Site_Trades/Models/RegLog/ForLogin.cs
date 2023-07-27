using Site_Trades.ViewModels;

namespace Site_Trades.Models.RegLog;

public static class ForLogin
{
    public static List<LoginViewModel> LogUsers = new List<LoginViewModel>();
   public static void Add( LoginViewModel user)
    {
        LogUsers.Add(user);
    }

   public static List<double> Profit = new List<double>();
   
   public static List<int> CountTrades = new List<int>();
   
   public static List<int> ProfitTrades = new List<int>();
   
   public static List<int> LoseTrades = new List<int>();
   
   
   
}

