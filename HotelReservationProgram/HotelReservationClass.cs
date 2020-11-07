using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationProgram
{
    public class HotelReservationClass
    {
<<<<<<< HEAD
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
=======
        public HotelType FindCheapestHotel(string startDate, string endDate, CustomerType type)
>>>>>>> UC2-FindCheapestHotel
        {
            HotelDetails LakeWood = new HotelDetails(HotelType.LAKEWOOD, type);
            HotelDetails BridgeWood = new HotelDetails(HotelType.BRIDGEWOOD, type);
            HotelDetails RidgeWood = new HotelDetails(HotelType.RIDGEWOOD, type);
            //Calculating Rate of Each Hotel Between the given dates
            double LakeWoodRate = LakeWood.FindTotalCost(startDate, endDate);
            double BridgeWoodRate = BridgeWood.FindTotalCost(startDate, endDate);
            double RidgeWoodRate = RidgeWood.FindTotalCost(startDate, endDate);
            double MinRate = Math.Min(LakeWoodRate, Math.Min(BridgeWoodRate, RidgeWoodRate));
            if (MinRate == LakeWoodRate && MinRate == BridgeWoodRate && MinRate == RidgeWoodRate)
                return HotelType.RIDGEWOOD;
            if (MinRate == LakeWoodRate && MinRate == BridgeWoodRate)
                return HotelType.BRIDGEWOOD;
            if (MinRate == BridgeWoodRate && MinRate == RidgeWoodRate)
                return HotelType.RIDGEWOOD;
            if (MinRate == LakeWoodRate && MinRate == BridgeWoodRate)
                return HotelType.RIDGEWOOD;
            if (MinRate == LakeWoodRate)
                return HotelType.LAKEWOOD;
            if (MinRate == BridgeWoodRate)
                return HotelType.BRIDGEWOOD;
            return HotelType.RIDGEWOOD;
        }
<<<<<<< HEAD
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
=======
        public HotelType FindBestRatedHotel(string startDate, string endDate, CustomerType type)
        {
            HotelDetails RidgeWood = new HotelDetails(HotelType.RIDGEWOOD, type);
            HotelDetails BridgeWood = new HotelDetails(HotelType.BRIDGEWOOD, type);
            HotelDetails LakeWood = new HotelDetails(HotelType.LAKEWOOD, type);
            double MaxRating = Math.Max(RidgeWood.RATING, Math.Max(BridgeWood.RATING, LakeWood.RATING));
            if (MaxRating == RidgeWood.RATING)
                return HotelType.RIDGEWOOD;
            if (MaxRating == BridgeWood.RATING)
                return HotelType.BRIDGEWOOD;
            else
                return HotelType.LAKEWOOD;
>>>>>>> UC2-FindCheapestHotel
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



