using HotelReservations;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IHotel
    {
        void InitializaRooms(int size);
        string CheckRoomAvailability(Reservation r);
        void MakeReservation(Reservation r, Dictionary<int, bool> availability);
        bool IsAvailable(Reservation r, Dictionary<int, bool> availability);
    }
}
