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

        public DbSet<RegistoChave> Chaves { get; set; }
        public DbSet<RegistoAposta> Apostas { get; set; }
        public ChavesContext(DbContextOptions<ChavesContext> options)
    : base(options)
        { }
    }
}


    
