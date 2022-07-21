using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectEst.API.Models;

namespace ProjectEst.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)   {       }
        public DbSet<Evento> Eventos {get; set; } 
    }
}