using Microsoft.EntityFrameworkCore;
using Site_Trades.Models;
using Site_Trades.Models.RegLog;
using Site_Trades.ViewModels;

namespace Site_Trades.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options ): base(options)
    {
    }

    public DbSet<Register> Users { get; set; }
    
    public DbSet<Trade> Trades { get; set; }


}