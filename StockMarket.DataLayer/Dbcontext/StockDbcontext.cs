using Microsoft.EntityFrameworkCore;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DataLayer.Dbcontext
{
   public class StockDbcontext : DbContext
    {
           public StockDbcontext(DbContextOptions<StockDbcontext> options)
           : base(options)
            {
            }

            public DbSet<Company> Company { get; set; }
            public DbSet<User> USer { get; set; }
            public DbSet<Company> IPODetail { get; set; }
           public DbSet<Company> StockExchange { get; set; }
           public DbSet<Company> StockPrice { get; set; }
    }
 }
