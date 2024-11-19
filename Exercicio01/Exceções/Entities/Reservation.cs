using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceções.Entities.Exception;

namespace Exceções.Entities
{
    internal class Reservation
    {
        public int NumRoom { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int numRomm, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must after check-In Date!");
            }

            NumRoom = numRomm;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if(checkin < now || checkout < now)
            {
                throw new DomainException("Reservation date for update must be future dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must after check-In Date!");
            }
            CheckIn = checkin;
            CheckOut = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.Days;
        }
        public override string ToString()
        {
            return $"Room : {NumRoom}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights.";
        }
    }
}
