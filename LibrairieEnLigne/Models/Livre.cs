namespace LibrairieEnLigne.Models
{
    public class Livre
    {
        public int LivreId { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public double Prix { get; set; }
        public int AuteurId { get; set; }

        public virtual Auteur Auteur { get; set; }
    }
}