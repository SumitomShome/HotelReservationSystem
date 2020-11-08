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
        [TestMethod]
        public void AddRating()
        {
            HotelDetails BridgeWood = new HotelDetails(HotelType.BRIDGEWOOD, CustomerType.NORMAL);
            double expectedRating = 4;
            double result = BridgeWood.RATING;
            Assert.AreEqual(expectedRating, result);
        }
        [TestMethod]
        public void CheapestBestRatedHotel()
        {
            HotelReservationClass service = new HotelReservationClass();
            HotelType hotel = service.FindCheapestBestRatedHotel("2020-09-08", "2020-09-09", CustomerType.NORMAL);
            HotelType expected = HotelType.BRIDGEWOOD;
            Assert.AreEqual(hotel, expected);
        }
        [TestMethod]
        public void BestRatedHotel()
        {
            HotelReservationClass service = new HotelReservationClass();
            HotelType hotel = service.FindBestRatedHotel("2020-09-08", "2020-09-09", CustomerType.NORMAL);
            HotelType expected = HotelType.RIDGEWOOD;
            Assert.AreEqual(hotel, expected);
        }
        [TestMethod]
        public void AddSpecialRate()
        {
            HotelDetails hotelDetails = new HotelDetails(HotelType.LAKEWOOD, CustomerType.REWARD);
            double expectedRate = 80;
            Assert.AreEqual(expectedRate, hotelDetails.WEEKDAY_RATE);
        }
        [TestMethod]
        public void BestRatedHotelForRewardCustomers()
        {
            HotelReservationClass service = new HotelReservationClass();
            HotelType hotel = service.FindCheapestBestRatedHotel("2020-09-11", "2020-09-12", CustomerType.REWARD);
            HotelType expected = HotelType.RIDGEWOOD;
            Assert.AreEqual(hotel, expected);
        }
    }
}