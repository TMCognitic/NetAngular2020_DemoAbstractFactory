using DemoAbstractFactory.Models.Commun;
using DemoAbstractFactory.Models.Egypte;
using DemoAbstractFactory.Models.Grec;
using System;

namespace DemoAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IBatimentSiege batiment = new BatimentSiegeGrec();

            Console.WriteLine(batiment.CreeBelier());
            Console.WriteLine(batiment.CreeCatapulte());
        }
    }
}
