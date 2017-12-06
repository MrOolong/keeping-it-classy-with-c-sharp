using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venue_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your venue?");
            Venue venue = new Venue();
            venue.Name = "The Jazz Hut";
            venue.Announce();
        }
    }
}
