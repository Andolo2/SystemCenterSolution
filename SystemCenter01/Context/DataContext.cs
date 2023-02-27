using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCenter01.Context
{
    internal class DataContext : DbContext
    {

        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options) // Add <Tickets>
        {
        }
    }
}
