using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationProgram
{
    public class HotelDetails
    {
        public string HotelName { get; set; }
        public int HotelRates { get; set; }
        public int WeekDayHotelRates { get; set; }
        public int WeekendHotelRates { get; set; }
        public int Rating { get; set; }
        public int NumberOfWeekDays { get; set; }
        public int NumberOfWeekends { get; set; }
    }
}
