using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dział6_1
{
  public   interface ITuningowalny
    {

        int ZwiekszPredkosc();
        
    }
    public abstract class Pojazd : ITuningowalny
    {
        public int predkosc { get; set; }
        public string model { get; set;}
        public Pojazd(int pr,string mod)
        {
            predkosc = pr;
            model = mod;
        }
       public  override string ToString()
        {
            return $"model:{model},\npredkość={predkosc.ToString()}";
        }
        public int ZwiekszPredkosc()
        {
            return predkosc += 10;
        }

    }
    public class Samochod:Pojazd,ITuningowalny
    {
        
        public int Liczbadrzwi { get; set; }
        public Samochod(int pr,string mod,int drzwi):base(pr,mod)
        {
           this.Liczbadrzwi = drzwi;
        }
        public override string ToString()
        {
            return $"{base.ToString()},\nLiczbaDrzwi={Liczbadrzwi.ToString()}";
        }
       

    }
    public class Samolot:Pojazd
    {
    public int LiczbaMiejsc { get; set; }

        public Samolot(int pr, string mod,int miejsca) : base(pr, mod)
        {
            this.LiczbaMiejsc = miejsca;
        }
        public int mie()
        {
            return LiczbaMiejsc;
        }
        public override  string ToString()
        {
            return base.ToString() + "LiczbaMiejsc="+mie();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Pojazd[] tab = new Pojazd[4];
            tab[0] = new Samochod(120, "matiz", 4);
            tab[1] = new Samochod(260, "BMW e46", 4);
            tab[2] = new Samolot(500, "F16", 1);
            tab[3] = new Samolot(509, "F22 Raptor", 6);
            Console.WriteLine(tab[3].ToString());
            /*for(int i=0; i<=3; i++)
            {
                Console.WriteLine();
                Console.WriteLine(tab[i].Info());
            }*/
            foreach(Pojazd i in tab)
            {
                Console.WriteLine();
                Console.WriteLine(i);
            }
            Console.WriteLine(tab[1].ZwiekszPredkosc());
            Console.ReadKey();
           
        }
    }
}
