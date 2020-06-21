using System.Collections.Generic;

namespace HotelReservations
{
    public interface IHotel
    {
        List<Room> GetHotelRooms();
        string CheckRoomAvailability(Reservation r);
        void InitializeRooms(int size);
        bool IsAvailable(Reservation r, Dictionary<int, bool> availability);
        void MakeReservation(Reservation r, Dictionary<int, bool> availability);
    }
}