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
            //Init des auteurs
            context.Auteurs.Add(new Auteur { AuteurId = 1, Nom = "Arthur C. Clarke" });
            context.Auteurs.Add(new Auteur { AuteurId = 2, Nom = "Andy Weir" });
            context.SaveChanges();

            //Init des livres
            context.Livres.Add(new Livre
            {
                LivreId = 1,
                Titre = "2001 l'odyssée de l'espace",
                Description = "Le vaisseau Explorateur 1 est en route vers Saturne. A son bord, deux astronautes et le plus puissant ordinateur jamais conçu, Carl 9000. Cinq ans plus tôt, un étrange monolithe noir a été découvert sur la Lune. La première preuve d'une existence extraterrestre. Et bien longtemps avant, à l'aube de l'humanité, un objet similaire s'était posé sur Terre et avait parlé aux premiers hommes. Un nouveau signe de cette présence a été détecté aux abords de Saturne. Que sont ces mystérieuses sentinelles ? Quel message doivent-elles délivrer ? Nous sommes en 2001. L'humanité a rendez-vous avec la porte des étoiles, aux confins du cosmos...",
                Prix = 13.6,
                Auteur = context.Auteurs.Where(a => a.AuteurId == 1).FirstOrDefault()
            });

            context.Livres.Add(new Livre
            {
                LivreId = 2,
                Titre = "2010 l'odyssée deux",
                Description = "Neuf ans après l'odyssée de l'espace, une nouvelle navette s'élance dans l'espace. A son bord, des Russes et des Américains bien décidés à rapporter à la Terre les réponses attendues.",
                Prix = 15,
                Auteur = context.Auteurs.Where(a => a.AuteurId == 1).FirstOrDefault()
            });

            context.Livres.Add(new Livre
            {
                LivreId = 3,
                Titre = "Seul sur Mars",
                Description = "Le roman à l'origine du film de Ridley Scott, le 21 octobre au cinéma ! Mark Watney est l’un des premiers humains à poser le pied sur Mars. Il pourrait bien être le premier à y mourir. Lorsqu’une tempête de sable mortelle force ses coéquipiers à évacuer la planète, Mark se retrouve seul et sans ressources, irrémédiablement coupé de toute communication avec la Terre. Pourtant Mark n’est pas prêt à baisser les bras. Ingénieux, habile de ses mains et terriblement têtu, il affronte un par un des problèmes en apparence insurmontables. Isolé et aux abois, parviendra-t-il à défier le sort ? Le compte à rebours a déjà commencé...",
                Prix = 7.9,
                Auteur = context.Auteurs.Where(a => a.AuteurId == 2).FirstOrDefault()
            });

            base.Seed(context);
        }
    }
}