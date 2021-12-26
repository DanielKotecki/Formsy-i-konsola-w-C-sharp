using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prograam_5._3
{
    enum Barwa
    {
        czerwony,
        zielony,
        złoty,
        czarny,
        srebny
    }
    class Samochod
    {
        private Barwa kolor;
        private string marka;
        private string rejestracja;

        public Samochod(Barwa kolor, string mar, string rej)
        {
            this.marka = mar;
            this.rejestracja = rej;

            this.kolor = kolor;
        }
        public void Info()
        {
            Console.WriteLine($"Marka:{marka},Rejestracja:{rejestracja},Kolor:{kolor}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Samochod car = new Samochod(Barwa.złoty, "fiat", "PKS 0796");

            car.Info();
            Console.ReadKey();

        }
    }
}



