using System;

namespace ConsoleApp1
{
    public class DyskHDD
    {
        private string Dane { get; set; }
        private IWtyczka _port { get; set; }
        private string nazwaPortu = "";

        public DyskHDD (IWtyczka port)
        {
            _port = port;
            nazwaPortu = _port.GetType().Name;
            Info();
        }

        public void PrzepnijPort(IWtyczka port)
        {
            _port = port;
            nazwaPortu = _port.GetType().Name;
            Info();
        }

        public void Info()
        {
            Console.WriteLine();
            Console.WriteLine("Obecnie podpięty port to " + nazwaPortu);
        }

        public void WgrajDane(string dane)
        {
            if (_port.CzyPodlaczony() == true)
            {
                _port.OdbierzDane(dane);
                Console.WriteLine("Przesylam dane z portu " + nazwaPortu);
                this.Dane = this.Dane + " | " + _port.PrzeslijDane() + " | " + "\n";
                Console.WriteLine("Wgrano dane na dysk");
            }
            else
            {
                Console.WriteLine("Nie mogę przesłać danych, podłącz port");
            }
        }

        public void PokazDane()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Wyswietlam dane z dysku");
            Console.WriteLine("-----------------------");
            Console.WriteLine(this.Dane);
            Console.WriteLine("-----------------------");
        }
    }
}
