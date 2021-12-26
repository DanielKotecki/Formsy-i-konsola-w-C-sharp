using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5._5
{
    enum Barwa
    {
        czerwony,
        zielony,
        złoty,
        czarny,
        srebny,
         
    }
    class Samochod
    {
      public static int licznik = 0;
     private readonly object Barwa;
      private readonly Barwa nieznany;

      private Barwa kolor { get; set; }
       private string  marka
        { get; set; }
       private string  rejestracja{ get; set; }
       
        
        /*3*/public Samochod(Barwa kolor,string mar, string rej):this()
        {
            
          this.marka = mar;
            this.rejestracja = rej;

          
        }
        ~Samochod()
        {
            licznik--;
            
        }
        /*2*/
        public Samochod( string mar, string rej) : this(mar)
        {
           
            this.kolor = nieznany; 
            this.rejestracja = rej;
        }
      
        /*1*/
        public Samochod(string mar)
        {
            licznik++;
            this.marka = mar;
        }
       /*0*/ public Samochod()
        {
            licznik++;
        }
    
        public void Info()
        {
           ;
            Console.WriteLine($"Marka:{marka},Rejestracja:{rejestracja},Kolor:{kolor}");
        }
       
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Samochod car = new Samochod(Barwa.srebny, "fiat", "PKS 0796");
            Console.WriteLine(Samochod.licznik);
            Samochod car2 = new Samochod("Ford","PKS");
            Console.WriteLine(car);
            car2.Info();
            car.Info();
            Console.WriteLine("Licznik końcowy:"+Samochod.licznik);
            car=null;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            Console.WriteLine($"Licznik:{Samochod.licznik}");
            Console.ReadKey();
        }
    }
}

