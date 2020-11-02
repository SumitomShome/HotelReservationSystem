using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationProgram
{
    public class HotelReservationClass
    {
        private Dictionary<string, HotelDetails> hotels = new Dictionary<string, HotelDetails>();
        public string AddHotelName(string name)
        {
            HotelDetails hotelDetails = new HotelDetails();
            hotelDetails.HotelName = name;
            hotels.Add(hotelDetails.HotelName, hotelDetails);
            return hotelDetails.HotelName;
        }
        public string AddHotelRating(string ratings)
        {
            HotelDetails hotelDetails = new HotelDetails();
            hotelDetails.HotelRating = ratings;
            hotels.Add(hotelDetails.HotelRating, hotelDetails);
            return hotelDetails.HotelRating;
        }
    }
}
