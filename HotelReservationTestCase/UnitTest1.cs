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
            string hotelRating = "800";
            string hotel = hotelReservationClass.AddHotelName(hotelName);
            string rating = hotelReservationClass.AddHotelRating(hotelRating);
            Assert.AreEqual(hotelName, hotel);
            Assert.AreEqual(hotelRating, rating);
        }
    }
}
