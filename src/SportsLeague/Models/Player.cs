using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SportsLeague.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerNumber { get; set; }
        public string PlayerPosition { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
