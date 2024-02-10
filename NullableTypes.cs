using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class MovieBookings
    {
        public static void Tickets()
        {
            //int? TicketsOnSale = null;
            int? TicketsOnSale = null;
            int AvailableTickets;

            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale;
            }

            Console.WriteLine($"AvailableTickets : {AvailableTickets}");
        }

        public static void NullCoalescing()
        {
            int? TicketsOnSale = 100;

            int AvailableTickets = TicketsOnSale ?? 0;

            Console.WriteLine($"AvailableTickets : {AvailableTickets}");

        }
    }
    class CheckMajor
    {
        public static void CheckAge()
        {
            //int? i = null;//nullable data type declaration
            bool? AreYouMajor = null;

            if (AreYouMajor == true)
            {
                Console.WriteLine("User is major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not major");
            }
            else
            {
                Console.WriteLine("did not answer and null value");
            }
        }

    }
    class NullableTypes
    {
        public static void RunProgram()
        {
            CheckMajor.CheckAge();
            MovieBookings.NullCoalescing();
        }
    }
}
