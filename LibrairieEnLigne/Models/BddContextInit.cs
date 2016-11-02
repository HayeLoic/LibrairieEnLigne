using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibrairieEnLigne.Models
{
    public class BddContextInit : DropCreateDatabaseAlways<BddContext>
    {
        protected override void Seed(BddContext context)
        {
            context.Livres.Add(new Livre { Id = 1, Titre = "Livre 1", Description = "Description du livre 1", Prix = 10 });
            context.Livres.Add(new Livre { Id = 1, Titre = "Livre 2", Description = "Description du livre 2", Prix = 12.5 });
            context.Livres.Add(new Livre { Id = 1, Titre = "Livre 3", Description = "Description du livre 3", Prix = 15 });

            base.Seed(context);
        }
    }
}