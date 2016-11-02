using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrairieEnLigne.Models
{
    public class Dal
    {
        protected BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}