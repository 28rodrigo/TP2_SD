using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2_SD.Models;

namespace TP2_SD.Database
{
    public class ChavesContext : DbContext
    {

        public DbSet<Chave> Chaves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TP2SD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    }
}


    
