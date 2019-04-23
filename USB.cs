using System;

namespace ConsoleApp1
{
    public class USB : IWtyczka
    {
        private string dane = "";
        private int PredkoscTransmisjiDanych { get; } = 700;
        private bool Podlaczony { get; set; } = false;

        public USB()
        {
            Podlaczony = true;
        }

        ~USB()
        {
            Podlaczony = false;
        }

        public bool CzyPodlaczony()
        {
            return Podlaczony;
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

        public void OdbierzDane(string dane)
        {
            this.dane = dane;
        }
    }
}
