using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laiterekisteri
{
    // Base class for devices
    class Device
    {
        // Fields
        // ------
        string identity = "Uusi laite";
        string dateBrought = "1.1.1997";
        double price = 0.00d;
        int warranty = 24;

        // Properties
        // ------
        public String Identity
        {
            get { return identity; }
            set { identity = value; }
        }
        public String DateBrought
        {
            get { return dateBrought; }
            set { dateBrought = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Warranty
        {
            get { return warranty; }
            set { warranty = value; }
        }

        // Constructors
        // ------
        public Device() { }

        //constructor with one argument
        public Device(string identity)
        {
            this.identity = identity;
        }

        //Another Constructor with all arguments
        public Device(string identity, string dateBrought, double price, int warranty)
        {
            this.identity = identity;
            this.dateBrought = dateBrought;
            this.price = price;
            this.warranty = warranty;
        }

        // Other Methods
    }






    // Class for computers
    class Computer : Device
    {
        // Fields
        // ------
        string identity;
        string dateBrought;
        double price;
        int warranty;

        // Properties
        // ------

        // Constructors
        // ------

        //constructor with one argument
        public Computer(string identity)
        {
            this.identity = identity;
        }

        //Another Constructor with all arguments
        public Computer(string identity, string dateBrought, double price, int warranty)
        {
            this.identity = identity;
            this.dateBrought = dateBrought;
            this.price = price;
            this.warranty = warranty;
        }

        // Other Methods
        // ------

    }





    // Class for phones
    class Phone : Device
    {
        // Fields
        // ------
        string identity;
        string dateBrought;
        double price;
        int warranty;

        // Properties
        // ------

        // Constructors
        // ------

        //constructor with one argument
        public Phone(string identity)
        {
            this.identity = identity;
        }

        //Another Constructor with all arguments
        public Phone(string identity, string dateBrought, double price, int warranty)
        {
            this.identity = identity;
            this.dateBrought = dateBrought;
            this.price = price;
            this.warranty = warranty;
        }

        // Other Methods
        // ------
    }





    // Class for Tablets
    class Tablet : Device
    {
        // Fields
        // ------
        string identity;
        string dateBrought;
        double price;
        int warranty;

        // Properties
        // ------

        // Constructors
        // ------

        //constructor with one argument
        public Tablet(string identity)
        {
            this.identity = identity;
        }

        //Another Constructor with all arguments
        public Tablet(string identity, string dateBrought, double price, int warranty)
        {
            this.identity = identity;
            this.dateBrought = dateBrought;
            this.price = price;
            this.warranty = warranty;
        }

        // Other Methods
        // ------

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            // create an test object from device class with default constructor (0 parameters)
            Device device1 = new Device();
            Console.WriteLine(device1.Identity);

            Console.WriteLine();

            //create another device with identity parametre
            Device device2 = new Device("Toinen Laite");
            Console.WriteLine(device2.Identity);

            Console.WriteLine();

            // create one more device with all parameters
            Device device3 = new Device("Acer Perärööri", "8.2.2024", 200.65, 24);
            Console.WriteLine(device3.Identity);
            Console.WriteLine(device3.Price + "e");


            Console.ReadLine();
        }
    }
}
