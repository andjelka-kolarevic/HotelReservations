using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations
{
    public class Reservation : IReservation
    {
        public int StartDate { get; set; }
        public int EndDate { get; set; }

        public Reservation(int start, int end)
        {
            StartDate = start;
            EndDate = end;
        }
    }
}
