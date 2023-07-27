using System.ComponentModel.DataAnnotations;

namespace Site_Trades.Models
{
    public class Trade
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        public double Marzha { get; set; }

        [Required]
        public double Profit { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

        public string? Email { get; set; }
    }
}
