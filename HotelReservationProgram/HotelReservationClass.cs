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
        public string AddHotelRate(string ratings)
        {
            HotelDetails hotelDetails = new HotelDetails();
            hotelDetails.HotelRate = rate;
            hotels.Add(hotelDetails.HotelRate, hotelDetails);
            return hotelDetails.HotelRate;
        }
    }
}
