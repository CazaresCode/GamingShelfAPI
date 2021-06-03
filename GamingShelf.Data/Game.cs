using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShelf.Data
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public int MinOfPlayers { get; set; }

        [Required]
        public int MaxOfPlayers { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int PlayTimeMinutes { get; set; }

        public string Publisher { get; set; }
        public int? MinAge { get; set; }
        public double? Rating { get; set; }
        //public bool IsFavorite { get; set; } MAKE DEFAULT SET TO FALSE IN MIGRATION IN UP().
    }
}
