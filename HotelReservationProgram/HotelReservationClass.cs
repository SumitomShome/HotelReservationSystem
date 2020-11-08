using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationProgram
{
    public class HotelReservationClass
    {
        public HotelType FindCheapestHotel(string startDate, string endDate, CustomerType type)
        {
            HotelDetails LakeWood = new HotelDetails(HotelType.LAKEWOOD, type);
            HotelDetails BridgeWood = new HotelDetails(HotelType.BRIDGEWOOD, type);
            HotelDetails RidgeWood = new HotelDetails(HotelType.RIDGEWOOD, type);
            //Calculating Rate of Each Hotel Between the given dates
            double LakeWoodRate = LakeWood.FindTotalCost(startDate, endDate);
            double BridgeWoodRate = BridgeWood.FindTotalCost(startDate, endDate);
            double RidgeWoodRate = RidgeWood.FindTotalCost(startDate, endDate);
            double MinRate = Math.Min(LakeWoodRate, Math.Min(BridgeWoodRate, RidgeWoodRate));
            if (MinRate == RidgeWoodRate)
                return HotelType.RIDGEWOOD;
            if (MinRate == LakeWoodRate)
                return HotelType.LAKEWOOD;
            if (MinRate == BridgeWoodRate)
                return HotelType.BRIDGEWOOD;
            return HotelType.RIDGEWOOD;
        }
        public HotelType FindCheapestBestRatedHotel(string startDate, string endDate, CustomerType type)
        {
            HotelDetails LakeWood = new HotelDetails(HotelType.LAKEWOOD, type);
            HotelDetails BridgeWood = new HotelDetails(HotelType.BRIDGEWOOD, type);
            HotelDetails RidgeWood = new HotelDetails(HotelType.RIDGEWOOD, type);
            double LakeWoodRate = LakeWood.FindTotalCost(startDate, endDate);
            double BridgeWoodRate = BridgeWood.FindTotalCost(startDate, endDate);
            double RidgeWoodRate = RidgeWood.FindTotalCost(startDate, endDate);
            double MinRate = Math.Min(LakeWoodRate, Math.Min(BridgeWoodRate, RidgeWoodRate));
            if (MinRate == RidgeWoodRate)
            {
                if(RidgeWood.RATING >= 4)
                {
                    return HotelType.RIDGEWOOD;
                }
                else if (LakeWoodRate < BridgeWoodRate)
                {
                    if (LakeWood.RATING >= 4)
                    {
                        return HotelType.LAKEWOOD;
                    }
                }
                else
                {
                    if (BridgeWood.RATING >= 4)
                    {
                        return HotelType.BRIDGEWOOD;
                    }
                }
            }
            if (MinRate == LakeWoodRate)
            {
                if (LakeWood.RATING >= 4)
                {
                    return HotelType.LAKEWOOD;
                }
                else if (RidgeWoodRate < BridgeWoodRate)
                {
                    if (RidgeWood.RATING >= 4)
                    {
                        return HotelType.RIDGEWOOD;
                    }
                }
                else
                {
                    if (BridgeWood.RATING >= 4)
                    {
                        return HotelType.BRIDGEWOOD;
                    }
                }
            }
            if(MinRate == BridgeWoodRate)
            {
                if(BridgeWood.RATING >= 4)
                {
                    return HotelType.BRIDGEWOOD;
                }
                else if (LakeWoodRate < RidgeWoodRate)
                {
                    if (LakeWood.RATING >= 4)
                    {
                        return HotelType.LAKEWOOD;
                    }
                }
                else
                {
                    if (RidgeWood.RATING >= 4)
                    {
                        return HotelType.RIDGEWOOD;
                    }
                }
            }
            return HotelType.RIDGEWOOD;
        }
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



