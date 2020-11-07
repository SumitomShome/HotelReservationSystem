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
        public void FindTheCheapestHotel()
        {
<<<<<<< HEAD
            HotelReservationClass hotelReservationClass = new HotelReservationClass();
            string hotelName = "Paradise";
            int hotelRate = 800;
            string hotel = hotelReservationClass.AddHotelName(hotelName, hotelRate);
            Assert.AreEqual(hotelName, hotel);
        }
        [TestMethod]
        public void CheapestRate()
        {
            HotelReservationClass hotelReservationClass = new HotelReservationClass();
            string expected = "Preston";
            Assert.AreEqual(expected, hotelReservationClass.GetCheapestHotel());
=======
            HotelReservationClass service = new HotelReservationClass();
            HotelType hotel = service.FindCheapestHotel("2020-09-11", "2020-09-12", CustomerType.NORMAL);
            HotelType expected = HotelType.RIDGEWOOD;
            Assert.AreEqual(hotel, expected);
>>>>>>> UC2-FindCheapestHotel
        }
    }
}
