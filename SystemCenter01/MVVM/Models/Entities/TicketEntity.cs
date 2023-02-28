using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemCenter01.MVVM.Models.Entities
{
    public class TicketEntity
    {
        public enum Status 
        {
            NotStarted,
            Started,
            Finished
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Description { get; set; } = null!;

        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        public Status Statuses { get; set; }


    }
}
