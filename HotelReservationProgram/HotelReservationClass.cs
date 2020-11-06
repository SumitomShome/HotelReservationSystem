using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationProgram
{
    public class HotelReservationClass
    {
        private string hotelName;
        private int hotelRate;
        private int totalRate;
        private int rating;
        private int numberOfWeekDays = 0;
        private int numberOfWeekends = 0;
        private Dictionary<string, HotelDetails> hotels = new Dictionary<string, HotelDetails>();
        public string AddHotelName(string hotelName, int hotelRate)
        {
            HotelDetails hotelDetails = new HotelDetails();
            hotelDetails.HotelName = hotelName;
            hotelDetails.HotelRates = hotelRate;
            hotels.Add(hotelDetails.HotelName, hotelDetails);
            return hotelName;
        }
        public int GetCheapestHotel(string nameOfHotel, int rateOfHotel)
        {
            HotelDetails hotelDetails = new HotelDetails();
            hotelDetails.HotelName = nameOfHotel;
            hotelDetails.HotelRates = rateOfHotel;
            int noOfDays;
            Console.WriteLine("Enter the date of check in");
            DateTime day1 = Convert.ToDateTime(Console.ReadLine());
            string date1 = day1.DayOfWeek.ToString();
            Console.WriteLine("Enter the date of checkout");
            DateTime day2 = Convert.ToDateTime(Console.ReadLine());
            string date2 = day2.DayOfWeek.ToString();
            noOfDays = (day2 - day1).Days;
            foreach (var lodge in hotels)
            {
                totalRate = hotelRate * noOfDays;
            }
            return totalRate;
        }
    }
}
