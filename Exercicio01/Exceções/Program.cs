using Exceções.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceções.Entities.Exception;

namespace Exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int numRoom = int.Parse(Console.ReadLine());
                Console.Write("Check-in Date: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out Date: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(numRoom, checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine("");
                Console.WriteLine("Enter the data to update the reservation: ");
                Console.Write("Check-in Date: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out Date: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservation update: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+ e.Message);
            }
        }
    }
}
