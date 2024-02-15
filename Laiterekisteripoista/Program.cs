using Laitekirjasto;
using System;
using System.Collections.Generic;
using System.Linq;
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
        double price = 0.0d;
        public double Price { get { return price; } set { price = value; } }

        int warranty = 12;
        public int Warranty { get { return warranty; } set { warranty = value; } }

        // Konstruktori eli olionmuodostin (constructor) ilman argumentteja
        public Device()
        {

        }

        // Konstruktori nimi-argumentilla
        public Device(string name)
        {
            this.name = name;
        }

        // Konstruktori kaikilla argumenteilla
        public Device(string name, string purchaseDate, double price, int warranty)
        {
            this.name = name;
            this.purchaseDate = purchaseDate;
            this.price = price;
            this.warranty = warranty;
        }



    }

    class Computer : Device
    {
        // kentät
        string processorType;
        public string ProcessorType { get { return processorType; } set {  processorType = value; } }
        
        int amountRam;
        public int AmountRam { get { return amountRam; } set {  amountRam = value; } }

        int storageCapacity;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }

        //konstructorit
        public Computer() : base()
        {

        }
        public Computer(string name) : base(name)
        {

        }

        // Muut metodit
        public void ShowInfo()
        {

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

            Device laite = new Device("Opekone");
            Console.WriteLine("Laitteen nimi on: " + laite.Name);
            Console.WriteLine("Ostopäivä oli: " + laite.PurchaseDate);

             //luodaan uusi tietokone joka perii laiteluokan (device) ominaisuudet ja metodit
            Computer tietokone1 = new Computer();

            // asetetaan prosessori-ominaisuuden arvo
            tietokone1.ProcessorType = "Intel i7";
            tietokone1.AmountRam = 32;
            Console.WriteLine("uuudestaan uudestaan...huusi Vainio. luodaan tietokone nimeltä `" +  tietokone1.Name + "` ja prosessorina toimii " + tietokone1.ProcessorType + " Ja muistia siinä on "  + tietokone1.AmountRam + " GB");
            Console.WriteLine();

            //Luodaan uusi nimetty tietokone toisella constructorilla
            Computer tietokone2 = new Computer("Rikun maaginen taistelu peruna");
            tietokone2.ProcessorType = "AMD Ryzen 9 5950x";
            tietokone2.AmountRam = 32;
            Console.WriteLine("luodaan tietokone nimeltä `" + tietokone2.Name + "` ja prosessorina toimii " + tietokone2.ProcessorType + " Ja muistia siinä on " + tietokone2.AmountRam + " GB");
            Console.WriteLine();



            // Pidetään ikkuna auki, kunnes käyttäjä painaa <enter>
            Console.ReadLine();
        }
    }
}
