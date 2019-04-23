using System;

namespace ConsoleApp1
{
    public class SATA : IWtyczka
    {
        private string dane = "";
        private int PredkoscTransmisjiDanych { get; } = 400;
        private bool Podlaczony { get; set; } = false;

        public SATA()
        {
            Podlaczony = true;
        }

        ~SATA()
        {
            Podlaczony = false;
        }

        public string PrzeslijDane()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(PredkoscTransmisjiDanych);
            }
            return dane;
        }

        public bool CzyPodlaczony()
        {
            return Podlaczony;
        }

        public void OdbierzDane(string dane)
        {
            this.dane = dane;
        }
    }
}
