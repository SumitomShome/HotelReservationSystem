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
        }
    }
}
