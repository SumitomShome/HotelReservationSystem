using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationProgram;
using System.Reflection.Metadata;
namespace HotelReservationProgram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddHotelInReservationSystem()
        {
            HotelReservationClass hotelReservationClass = new HotelReservationClass();
            string hotelName = "Paradise";
            string hotelRate = "800";
            string hotel = hotelReservationClass.AddHotelName(hotelName);
            string rate = hotelReservationClass.AddHotelRate(hotelRate);
            Assert.AreEqual(hotelName, hotel);
            Assert.AreEqual(hotelRate, rate);
        }
    }
}
