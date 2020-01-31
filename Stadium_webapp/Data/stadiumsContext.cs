using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stadium_webapp.Models.Stadiums;

namespace Stadium_webapp.Models
{
    public class stadiumsContext : DbContext
    {
        public stadiumsContext (DbContextOptions<stadiumsContext> options)
            : base(options)
        {
        }

        public DbSet<Stadium_webapp.Models.Stadiums.stadiums> stadiums { get; set; }
    }
}
