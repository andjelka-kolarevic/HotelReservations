using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations
{
    public class Room : IRoom
    {
        public Dictionary<int, bool> Availability { get; set; }

        public Room()
        {
            Availability = new Dictionary<int, bool>();
            AddKeyValues();
        }

        public void AddKeyValues()
        {
            for (int i = 0; i < 365; i++)
            {
                Availability.Add(i, true);
            }
        }
    }
}
