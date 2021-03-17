using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionE.Entites
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must...");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Error in reservation: Reservation dates for future");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must...");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + "check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                    + "nights";
        }
    }
}
