using System.Collections.Generic;

namespace LibrairieEnLigne.Models
{
    public class Auteur
    {
        public int AuteurId { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Livre> Livres { get; set; }

        public Auteur()
        {
            this.Livres = new HashSet<Livre>();
        }
    }
}