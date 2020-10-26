using DemoAbstractFactory.Models.Commun;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstractFactory.Models.Grec
{
    public class BatimentSiegeGrec : IBatimentSiege
    {
        public Belier CreeBelier()
        {
            return new BelierGrec();
        }

        public Catapulte CreeCatapulte()
        {
            return new CatapulteGrecque();
        }
    }
}
