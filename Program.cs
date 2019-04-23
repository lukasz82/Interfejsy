using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWtyczka Sata = new SATA();
            IWtyczka Usb = new USB();

            DyskHDD Segate = new DyskHDD(Sata);

            Segate.WgrajDane("Dane z jakiegoś źródła");
            Segate.PokazDane();

            Segate.PrzepnijPort(Usb);

            Segate.WgrajDane("Dane z jakiegoś innego źródła");
            Segate.PokazDane();

            Segate.PrzepnijPort(Sata);

            Segate.WgrajDane("Jeszcze inne Dane z jakiegoś źródła");
            Segate.PokazDane();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
