using System;
using Lib_Emprunt;
namespace Emprunt_exo
{
    class Program
    {
        static void Main(string[] args)
        {

            double zorg;
            Emprunt test = new Emprunt(0.5, 20, 100000);
            zorg = test.CalculerMensualite();


            Console.WriteLine(test.CapitalEmprunte);
            Console.WriteLine(test.TauxInteretAnnuel);
            Console.WriteLine(test.NbrAnneeRbmt);


            Console.WriteLine (zorg);
            Console.ReadKey();
        }
    }
}
