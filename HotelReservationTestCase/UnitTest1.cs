using System;
using HotelReservationProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HotelReservationSystemTest
{
    [TestClass]
    public class UnitTests
    {
        public void Test()
        {
        }
        [TestMethod]
        public void AddHotelToTheList()
        {
            HotelDetails hotelDetails = new HotelDetails(HotelType.LAKEWOOD, CustomerType.NORMAL);
            double expectedRate = 110;
            Assert.AreEqual(expectedRate, hotelDetails.WEEKDAY_RATE);
        }
        [TestMethod]
        public void FindCheapestWeekendRate()
        {
            HotelReservationClass service = new HotelReservationClass();
            HotelType hotel = service.FindCheapestHotel("2020-09-12", "2020-09-13", CustomerType.NORMAL);
            HotelType expected = HotelType.BRIDGEWOOD;
            Assert.AreEqual(hotel, expected);
        }
        [TestMethod]
        public void FindCheapestWeekdaysRate()
        {
            HotelReservationClass service = new HotelReservationClass();
            HotelType hotel = service.FindCheapestHotel("2020-09-08", "2020-09-09", CustomerType.NORMAL);
            HotelType expected = HotelType.LAKEWOOD;
            Assert.AreEqual(hotel, expected);
        }
    }
}