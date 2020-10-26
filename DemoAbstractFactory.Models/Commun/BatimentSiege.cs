using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstractFactory.Models.Commun
{
    //Fabrique
    public interface IBatimentSiege
    {
        Belier CreeBelier();
        Catapulte CreeCatapulte();
    }
}
