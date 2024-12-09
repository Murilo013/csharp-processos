using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.Models;

namespace teste.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
            => opt.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
