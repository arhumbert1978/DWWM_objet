using System;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {

            Compte Tartempion= new Compte(-2000,"taratata","1254877985r555",1359);
            Console.WriteLine(Tartempion);
            Console.ReadKey();
            Tartempion.credit (1254);
            Tartempion.debit(156.77);
            Console.WriteLine(Tartempion);
            Console.ReadKey();

        }
    }
}
