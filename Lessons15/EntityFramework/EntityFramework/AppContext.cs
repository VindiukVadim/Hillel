using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class AppContext: DbContext
    {
        public AppContext() : base()
        {

        }

        protected override void OnConfiguring (DbContextOptionsBuilder dbContextOptionBuilder)
        {
            dbContextOptionBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=Lessons15;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get;set; }
    }
}
