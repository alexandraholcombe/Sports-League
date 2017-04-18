using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeague.Models
{
    [Table("Divisions")]
    public class Division
    {
        public Division()
        {
            this.Teams = new HashSet<Team>();
        }

        [Key]
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}