using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SystemCenter01.MVVM.Models.Entities.TicketEntity;

namespace SystemCenter01.MVVM.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string StreetName { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;

        public string Description { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public Status Statuses { get; set; }
    }
}
