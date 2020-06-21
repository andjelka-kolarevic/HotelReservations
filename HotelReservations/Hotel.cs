using System;
using System.Collections.Generic;

namespace HotelReservations
{
    public class Hotel : IHotel
    {
        public List<Room> HotelRooms { get; set; }
        public Hotel(int size)
        {
            if (size < 1 || size > 1000)
            {
                throw new ArgumentOutOfRangeException("Size must be in [1, 1000]!");
            }
            HotelRooms = new List<Room>();
            InitializeRooms(size);
        }

        public void InitializeRooms(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                HotelRooms.Add(new Room());
            }
        }
        public List<Room> GetHotelRooms()
        {
            return HotelRooms;
        }
        public string CheckRoomAvailability(Reservation r)
        {
            foreach (Room room in HotelRooms)
            {
                if (IsAvailable(r, room.Availability))
                {
                    MakeReservation(r, room.Availability);
                    return "Accept";
                }
            }
            return "Decline";
        }

        public void MakeReservation(Reservation r, Dictionary<int, bool> availability)
        {
            for (int i = r.StartDate; i <= r.EndDate; i++)
            {
                availability[i] = false;
            }
        }

        public bool IsAvailable(Reservation r, Dictionary<int, bool> availability)
        {
            int counter = 0;
            if (r.StartDate < 0 || r.StartDate > 365 || r.EndDate < 0 || r.EndDate > 365)
            {
                return false;
            }
            int duration = r.EndDate - r.StartDate + 1;
            for (int i = r.StartDate; i <= r.EndDate; i++)
            {
                if (availability[i])
                {
                    counter++;
                }
            }
            if (counter == duration)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
