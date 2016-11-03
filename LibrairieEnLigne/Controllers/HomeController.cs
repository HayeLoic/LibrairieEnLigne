﻿using LibrairieEnLigne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrairieEnLigne.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Liste de tous les livres
            DalLivre dalLivre = new DalLivre();
            
            return View(dalLivre.GetLivres());
        }

        public ActionResult Recherche(string recherche)
        {
            //Liste des livres correspondant à la recherche
            DalLivre dalLivre = new DalLivre();

            //List<Livre> test = dalLivre.GetLivres(recherche);
            return View("Index",dalLivre.GetLivres(recherche));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}