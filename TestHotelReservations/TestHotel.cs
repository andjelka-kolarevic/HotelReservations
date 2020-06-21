using HotelReservations;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Xunit;

namespace TestHotelReservations
{
    public class TestHotel
    {   
        static IHotel hotel1 = new Hotel(1);     
        static IHotel hotel2 = new Hotel(3);
        static IHotel hotel3 = new Hotel(3);
        static IHotel hotel4 = new Hotel(3);
        static IHotel hotel5 = new Hotel(2);

        public TestHotel()
        {
            //please ReadMe file!
        }

        #region Tests for CheckRoomAvailability method

        [Theory(DisplayName = "When Reservation from Test1a_b DB is passed Then expected and actual value of method should be equals")]
        [MemberData(nameof(FakeDBReservations.Test1a_b), MemberType = typeof(FakeDBReservations))]
        public void TestCase1a_b(Reservation res, string expectedResult)
        {
            //arrange

            //act
            var actualResult = hotel1.CheckRoomAvailability(res);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory(DisplayName = "When Reservation from Test2 DB is passed Then expected and actual value of method should be equals")]
        [MemberData(nameof(FakeDBReservations.Test2), MemberType = typeof(FakeDBReservations))]
        public void TestCase2(Reservation res, string expectedResult)
        {
            //arrange

            //act
            var actualResult = hotel2.CheckRoomAvailability(res);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory(DisplayName = "When Reservation from Test3 DB is passed Then expected and actual value of method should be equals")]
        [MemberData(nameof(FakeDBReservations.Test3), MemberType = typeof(FakeDBReservations))]
        public void TestCase3(Reservation res, string expectedResult)
        {
            //arrange

            //act
            var actualResult = hotel3.CheckRoomAvailability(res);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory(DisplayName = "When Reservation from Test4 DB is passed Then expected and actual value of method should be equals")]
        [MemberData(nameof(FakeDBReservations.Test4), MemberType = typeof(FakeDBReservations))]
        public void TestCase4(Reservation res, string expectedResult)
        {
            //arrange

            //act
            var actualResult = hotel4.CheckRoomAvailability(res);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory(DisplayName = "When Reservation from Test5 DB is passed Then expected and actual value of method should be equals")]
        [MemberData(nameof(FakeDBReservations.Test5), MemberType = typeof(FakeDBReservations))]
        public void TestCase5(Reservation res, string expectedResult)
        {
            //arrange

            //act
            var actualResult = hotel5.CheckRoomAvailability(res);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        #endregion

        #region Tests for MakeReservation method

        [Theory(DisplayName ="When Reservation is passed Then number of false values should be equal with period of Reservation")]
        [InlineData(2, 10, 9)]
        [InlineData(2, 2, 1)]
        [InlineData(0, 5, 6)]
        public void TestMakeReservation(int start, int end, int expectedPeriod)
        {
            //arrange
            Hotel hotel = new Hotel(2);
            Reservation reservation = new Reservation(start, end);
            Dictionary<int, bool> roomAvailability = hotel.HotelRooms.First().Availability;

            //act
            hotel.MakeReservation(reservation, roomAvailability);

            //assert
            Assert.Equal(expectedPeriod, roomAvailability.Where(x => x.Value == false).ToList().Count);
        }

        #endregion

        #region Tests for IsAvailable method

        [Theory(DisplayName ="When invalid start/end date is passed Then IsAvaliable method returns false")]
        [InlineData(-4, 20)]
        [InlineData(-4, -200)]
        [InlineData(10, 400)]
        [InlineData(0, -20)]

        public void TestIsAvailableWithInvalidParametars(int start, int end)
        {
            //arrange
            Hotel hotel = new Hotel(2);
            Reservation reservation = new Reservation(start, end);
            Dictionary<int, bool> roomAvailability = hotel.HotelRooms.First().Availability;

            //act
            var result = hotel.IsAvailable(reservation, roomAvailability);

            //assert
            Assert.False(result);
        }

        [Theory(DisplayName = "When valid start/end date is passed Then IsAvaliable method returns result equal with expected")]
        [InlineData(1, 5, true)]
        [InlineData(0, 0, true)]
        [InlineData(0, 2, false)]
        [InlineData(6, 6, true)]
        [InlineData(2, 4, false)]

        public void TestIsAvailableWithValidParametars(int start, int end, bool expectedValue)
        {
            //arrange
            Reservation reservation = new Reservation(start, end);
            Dictionary<int, bool> roomAvailability = hotel1.GetHotelRooms().First().Availability;

            //act
            var result = hotel1.IsAvailable(reservation, roomAvailability);
            if(result)
            {
                hotel1.MakeReservation(reservation, roomAvailability);
            }

            //assert
            Assert.Equal(expectedValue, result);
        }

        #endregion

        #region Tests for Constructor

        [Theory(DisplayName ="When invalid size is passed Then HotelConstructor throws ArgumentOutOfRangeException")]
        [InlineData(0)]
        [InlineData(1001)]
        public void TestConstructorInvalidSize(int size)
        {
            //arrange

            //act

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Hotel(size));
        }

        #endregion
    }
}
