using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    partial class Train
    {
        public Train(string drivername, string color, int speed, int numberofPassengers, string destination)
        {
            DriverName = drivername;
            Color = color;
            Speed = speed;
            NumberofPassengers = numberofPassengers;
            Destination = destination;
        }
        public Train()
        {
            DriverName = " ";
            Color = "";
            Speed = 0;
            NumberofPassengers = 0;
            Destination = "";
        }
        public Train(string drivername, string color)
        {
            DriverName = drivername;
            Color = color;
            Speed = 1000;
            NumberofPassengers = 50;
            Destination = "Sumqait";
        }

        public string DriverName { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public int NumberofPassengers { get; set; }
        public string Destination { get; set; }
        public static int NumberOfCabins { get; set; }
        public static string ModelName { get; set; }
        static Train()
        {


            ModelName = "BakuTrain";
            NumberOfCabins = 8;
        }






        public override string ToString()
        {
            return $"Drivername: {DriverName} Color: {Color} Speed: {Speed} NumberofPassengers: {NumberofPassengers } Destination: {Destination}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Train[] trains = new Train[5] {

                new Train( "Driver1","Black",10000,50,"Qabala"),
               new Train( "Driver2","Black",10000,50,"Qax"),
               new Train ( "Driver3","Black",10000,50,"Sumqait"),
                    new Train ("Driver4","Black",10000,50,"Barda"),
                       new Train ( "Driver5","Black",10000,50,"Istanbul")
            };
            foreach (var item in trains)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");
            trains[2].ChangeDestination("Ankara"); ;
            foreach (var item in trains)
            {
                Console.WriteLine(item);
            }

        }


    }
}
