using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laitekirjasto
{
    // Yleinen laiteluokka, yliluokka tietokoneille, tableteille ja puhelimille
    class Device
    {
        // Luodaan kenttä (field) name, esitellään (define) ja annetaan arvo (set initial value)
        string name = "Uusi laite";
        // Luodaan kenttää vastaava ominaisuus (property) Name ja sille asetusmetodi set ja lukumetodi get. Ne voi kirjoittaa joko yhdelle tai useammalle riville

        public string Name { get { return name; } set { name = value; } }

        string purchaseDate = "1.1.1900";
        public string PurchaseDate { get { return purchaseDate; } set { purchaseDate = value; } }

        // Huomaa jälkiliite d (suffix)
        // -------------------------------

        double price = 0.0d;
        public double Price { get { return price; } set { price = value; } }

        int warranty = 12;
        public int Warranty { get { return warranty; } set { warranty = value; } }


        string processorType = "N/A";
        public string ProcessorType { get { return processorType; } set { processorType = value; } }

        int amountRAM = 0;
        public int AmountRam { get { return amountRAM; } set { amountRAM = value; } }

        int storageCapacity = 0;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }


        // Konstruktori eli olionmuodostin (constructor) ilman argumentteja
        // -------------------------------

        public Device()
        {

        }

        // Konstruktori nimi-argumentilla
        // -------------------------------

        public Device(string name)
        {
            this.name = name;
        }

        // Konstruktori kaikilla argumenteilla
        // -------------------------------

        public Device(string name, string purchaseDate, double price, int warranty)
        {
            this.name = name;
            this.purchaseDate = purchaseDate;
            this.price = price;
            this.warranty = warranty;
        }

        // yliluokan methodit
        // -------------------------------

        public void ShowPurchaseInfo()
        {
            Console.WriteLine("Laitteen nimi: " + this.name);
            Console.WriteLine("ostopäivä: " + this.purchaseDate);
            Console.WriteLine("Hankinta hinta: " + this.price);
            Console.WriteLine("Takuu: " + this.warranty + " kuukautta");
        }
        // luodaan laitteen yleiset tekniset tiedot  ominaisuuksista, huom iso alkukirjain
        // -------------------------------

        public void ShowBasicTechnicalInfo()
        {
            Console.WriteLine("Koneen nimi: " + Name);
            Console.WriteLine("Prosessori: " + ProcessorType);
            Console.WriteLine("Keskusmuisti: " + AmountRam);
            Console.WriteLine("Levytila: " + StorageCapacity);
        }

    }

    // Tietokoneiden luokka, perii ominaisuuksia ja metodeja laiteluokasta Device

    class Computer : Device
    {

        // Konstruktorit
        // -------------------------------

        public Computer() : base()
        { }

        public Computer(string name) : base(name)
        { }

        // Muut metodit
        // -------------------------------

        public void ShowInfo()
        {
            Console.WriteLine("Koneen nimi: " + Name);
            Console.WriteLine("Prosessori: " + ProcessorType);
            Console.WriteLine("Keskusmuisti: " + AmountRam);
            Console.WriteLine("Levytila: " + StorageCapacity);
        }
    }

    // Tablettien luokka, perii laiteluokan
    class Tablet : Device
    {
        // Kentät
        // -------------------------------
        string operatingSystem;
        public string OperatingSystem { get { return operatingSystem; } set { operatingSystem = value; } }
        bool stylusEnabled = false;
        public bool StylusEnabled { get { return stylusEnabled; } set { stylusEnabled = value; } }



        // Constructorit
        // -------------------------------
        public Tablet() : base() { }
        public Tablet(string name) : base(name) { }

        
        // Tablet-luokan erikoismetodit
        // -------------------------------
        public void TabletInfo()
        {
            Console.WriteLine("Käyttöjärjestelmä: " + OperatingSystem);
            Console.WriteLine("Prosessori: " + ProcessorType);
            Console.WriteLine("Kynätuki: " +StylusEnabled);

        }
    }



    // Pääohjelman luokka, josta tulee Program.exe
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ohjelman varsinaiset toiminnot tapahtuvat täällä
            // Ohjelma kysyy käyttäjältä tietoja laitteista ja
            // vastaamalla kysymyksiin tiedot tallennetaan muuttujiin.

            // Luodaan uusi laite Device-luokasta

            //Device laite = new Device("Opekone");
            //Console.WriteLine("Laitteen nimi on: " + laite.Name);
            //Console.WriteLine("Ostopäivä oli: " + laite.PurchaseDate);

            // Luodaan uusi tietokone, joka perii laiteluokan (Device) ominaisuudet ja metodit
            Computer tietokone1 = new Computer();
            // Asetetaan Prosessori-ominaisuuden arvo
            tietokone1.ProcessorType = "Intel I7";
            tietokone1.AmountRam = 16;
            tietokone1.PurchaseDate = "20.20.2022";
            tietokone1.Price = 890.95d;
            tietokone1.Warranty = 36;

            Console.WriteLine("tietokone1:n hankintatiedot");
            Console.WriteLine("B=================================3");
            tietokone1.ShowPurchaseInfo();
            Console.WriteLine(); 
            //Console.WriteLine("Uuden tietokoneen nimi on: " + tietokone1.Name + " ja siinä on " + tietokone1.ProcessorType + " -prosessori ja " + tietokone1.AmountRam + " GB keskusmuistia");

            // Luodaan uusi nimetty tietokone toisella konstruktorilla
            Computer tietokone2 = new Computer("Mikan läppäri");
            tietokone2.ProcessorType = "Intel Core i7 vPro";
            tietokone2.AmountRam = 32;

            Console.WriteLine("tietokone2:n tekniset tiedot");
            Console.WriteLine("B=================================3");
            tietokone2.ShowBasicTechnicalInfo();
           
            Console.WriteLine();

            Tablet tablet1 = new Tablet("vitun lääpilääpi");
            tablet1.OperatingSystem = "Android 13";
            tablet1.ProcessorType = "arm64 snapdragon 865";
            tablet1.AmountRam = 8;
            tablet1.Price = 400;
            tablet1.Warranty = 24;
            tablet1.StorageCapacity = 512;
            tablet1.PurchaseDate = "20.20.1991";
            tablet1.StylusEnabled = true;

            Console.WriteLine("tabletin tiedot");
            Console.WriteLine("B=================================3");
            tablet1.ShowPurchaseInfo();
            tablet1.TabletInfo();


            // Pidetään ikkuna auki, kunnes käyttäjä painaa <enter>
            Console.ReadLine();
        }
    }
}