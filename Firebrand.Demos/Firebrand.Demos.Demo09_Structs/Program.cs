using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Longitude");
            int lng = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Latitude");
            int lat = Convert.ToInt32(Console.ReadLine());

            Coordinates MyCoordinates = new Coordinates();
            MyCoordinates.latitude = lat;
            MyCoordinates.longitude = lng;

            Console.WriteLine("Latitude is: " + MyCoordinates.latitude);
            Console.WriteLine("Longitude is: " + MyCoordinates.longitude);

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }

    public struct Coordinates
    {
        private int _latitude, _longitude;

        public int latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                _latitude = value;
            }
        }

        public int longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                _longitude = value;
            }
        }

    }
}
