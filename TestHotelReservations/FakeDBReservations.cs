using HotelReservations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestHotelReservations
{
    public class FakeDBReservations : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> Test1a_b =>
            new List<object[]>
            {
                new object[]
                {
                    new Reservation(-4, 2),
                    "Decline"
                },
                new object[] 
                { 
                    new Reservation(200, 400),
                    "Decline"
                }
            };
        public static IEnumerable<object[]> Test2 =>
            new List<object[]>
            {
                new object[]
                {
                    new Reservation(0, 5),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(7, 13),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(3, 9),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(5, 7),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(6, 6),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(0, 4),
                    "Accept"
                }
            };
        public static IEnumerable<object[]> Test3 =>
            new List<object[]>
            {
                new object[]
                {
                    new Reservation(1, 3),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(2, 5),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(1, 9),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(0, 15),
                    "Decline"
                }
            };
        public static IEnumerable<object[]> Test4 =>
            new List<object[]>
            {
                new object[]
                {
                    new Reservation(1, 3),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(0, 15),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(1, 9),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(2, 5),
                    "Decline"
                },
                new object[]
                {
                    new Reservation(4, 9),
                    "Accept"
                }
            };
        public static IEnumerable<object[]> Test5 =>
            new List<object[]>
            {
                new object[]
                {
                    new Reservation(1, 3),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(0, 4),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(2, 3),
                    "Decline"
                },
                new object[]
                {
                    new Reservation(5, 5),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(4, 10),
                    "Decline"
                },
                new object[]
                {
                    new Reservation(10, 10),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(6, 7),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(8, 10),
                    "Accept"
                },
                new object[]
                {
                    new Reservation(8, 9),
                    "Accept"
                }
            };
        public IEnumerator<object[]> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
