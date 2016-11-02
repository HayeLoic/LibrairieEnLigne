using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrairieEnLigne.Models
{
    public class DalLivre : Dal
    {
        public List<Livre> GetLivres()
        {
            return bdd.Livres.ToList();
        }
    }
}