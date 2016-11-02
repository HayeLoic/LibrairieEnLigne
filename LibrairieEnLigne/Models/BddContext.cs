using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibrairieEnLigne.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Livre> Livres { get; set; }
    }
}