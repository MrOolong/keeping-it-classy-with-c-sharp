using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your venue?");
            string venue = args[0];
            Console.WriteLine(Announce(venue));
        }

        static string Announce(string venue)
        {
            return venue + " will have bands performing tonight.";
        }
    }
}

