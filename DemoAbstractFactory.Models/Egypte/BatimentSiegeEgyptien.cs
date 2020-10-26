using DemoAbstractFactory.Models.Commun;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstractFactory.Models.Egypte
{
    public class BatimentSiegeEgyptien : IBatimentSiege
    {
        public Belier CreeBelier()
        {
            return new BelierEgyptien();
        }

        public Catapulte CreeCatapulte()
        {
            return new CatapulteEgyptienne();
        }
    }
}
