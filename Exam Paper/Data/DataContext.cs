using Exam_Paper.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Paper.Data
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString = "Server=LAPTOP-HP52IBIJ\\SQLEXPRESS; Database=ExamProduct; User Id=sa; Password=12345678; Trusted_Connection=True; TrustServerCertificate=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<Product>Products { get; set; }

    }
}
