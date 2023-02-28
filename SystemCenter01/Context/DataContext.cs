using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemCenter01.MVVM.Models.Entities;

namespace SystemCenter01.Context
{
    internal class DataContext : DbContext
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Webbutveckling-DotNet\DotNet\SystemCenterSolution\SystemCenter01\Context\SQLDATA01.mdf;Integrated Security=True;Connect Timeout=30";

        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<DepartmentEntity> Departments { get; set; } = null!;
        public DbSet<UserEntity> Users { get; set; } = null!;
        public DbSet<TicketEntity> Tickets { get; set; } = null!;
    }
}
