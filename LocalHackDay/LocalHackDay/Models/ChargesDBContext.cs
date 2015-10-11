using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LocalHackDay.Models
{
    public class ChargesDBContext : DbContext
    {
        public DbSet<Charge> Charges { get; set; }

        public DbSet<Bill> Bills { get; set; }
    }
}