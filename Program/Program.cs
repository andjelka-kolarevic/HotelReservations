using HotelReservations;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel(3);
            Reservation r1 = new Reservation(0, 0); //accept
            Reservation r2 = new Reservation(0, 2); //accept
            Reservation r3 = new Reservation(2, 4); //accept
            Reservation r4 = new Reservation(2, 2); //accept
            Reservation r5 = new Reservation(-1, 3); //decline

            var res1 = hotel.CheckRoomAvailability(r1);
            var res2 = hotel.CheckRoomAvailability(r2);
            var res3 = hotel.CheckRoomAvailability(r3);
            var res4 = hotel.CheckRoomAvailability(r4);
            var res5 = hotel.CheckRoomAvailability(r5);
            Console.WriteLine(res1 + res2 + res3 + res4 + res5);
        }
    }
}
