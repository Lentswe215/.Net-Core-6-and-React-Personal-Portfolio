#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LenMamPortfolio.Models;

namespace LenMamPortfolio.Data
{
    public class LenMamPortfolioContext : DbContext
    {
        public LenMamPortfolioContext (DbContextOptions<LenMamPortfolioContext> options)
            : base(options)
        {
        }

        public DbSet<UserData> UserData { get; set; }

        public DbSet<ContactMessages> ContactMessages { get; set; }

        public DbSet<Skills> Skills { get; set; }

        public DbSet<Projects> Projects { get; set; }

        public DbSet<ContentPages> ContentPages { get; set; }
    }
}
