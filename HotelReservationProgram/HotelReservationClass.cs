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
        private int weekDaysRate;
        private int weekendRate;
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
        public int GetCheapestHotel(string nameOfHotel, int weekDaysRateOfHotel, int weekendRateOfHotel)
        {
            HotelDetails hotelDetails = new HotelDetails();
            hotelDetails.HotelName = nameOfHotel;
            hotelDetails.WeekDayHotelRates = weekDaysRateOfHotel;
            hotelDetails.WeekendHotelRates = weekendRateOfHotel;
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
                if (date1 == "Saturday" || date1 == "Sunday" || date2 == "Saturday" || date2 == "Sunday")
                {
                    totalRate = GetWeekDaysRate(nameOfHotel, weekendRateOfHotel, noOfDays);
                }
                else
                {
                    totalRate = GetWeekendRate(nameOfHotel, weekDaysRateOfHotel, noOfDays);
                }
                //totalRate = hotelRate * noOfDays;
            }
            return totalRate;
        }
        public int GetWeekDaysRate(string nameOfTheHotel, int rateOfTheHotel, int numberOfDays)
        {
            int wdaysRate = rateOfTheHotel * numberOfDays;
            return wdaysRate;
        }
        public int GetWeekendRate(string nameOfTheHotel, int rateOfTheHotel, int numberOfDays)
        {
            int wdaysRate = rateOfTheHotel * numberOfDays;
            return wdaysRate;
        }
    }
}
