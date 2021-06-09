using Microsoft.EntityFrameworkCore;
using SD_TP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_TP2.Database
{
    public class ChavesContext : DbContext
    {

        public DbSet<RegistoAposta> Apostas { get; set; }
        public ChavesContext(DbContextOptions<ChavesContext> options)
    : base(options)
        { }
    }
}


    
