using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCenterConsole.Models.Entities
{
    public class TicketsEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Description { get; set; } = null!;

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        public string Status { get; set; } = null!;

        public string TicketText { get; set; } = null!;

    }
}
