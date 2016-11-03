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

        public List<Livre> GetLivres(string recherche)
        {
            return bdd.Livres.Where(l => l.Titre.Contains(recherche) || l.Auteur.Nom.Contains(recherche)).ToList();
        }
    }
}