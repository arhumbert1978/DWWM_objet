using System;

namespace compte
{
    class Program
    {
        static void Main(string[] args)
        {
            string e = Encoding.Default.GetString(new Byte[] { 128 });
            Console.OutputEncoding = Encoding.Default;

            compteBanque Tartempion = new compteBanque(-2000, "Zorgleub", "123578", 1234);

            Console.writeline(tartempion);
            Console.readkey;


        }
    }
}
