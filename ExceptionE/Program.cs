using System;
using ExceptionE.Entites;

namespace ExceptionE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            if (checkOut <= checkIn)
            { 
                Reservation reservation = new Reservation(number, checkIn, checkOut);
            } else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: "  + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for future");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must...");
                } else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation " + reservation);
                }
            }
        }
    }
}
