using System;
namespace HotelReservationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Registration Program");
            HotelReservationClass hotelReservationClass = new HotelReservationClass();
            hotelReservationClass.AddHotelName("Paradise", 800);
            hotelReservationClass.AddHotelName("Joseph", 1000);
            hotelReservationClass.AddHotelName("Pranton", 600);
            if(hotelReservationClass.GetCheapestHotel("Paradise", 800) < hotelReservationClass.GetCheapestHotel("Joseph", 1000) && hotelReservationClass.GetCheapestHotel("Paradise", 800) < hotelReservationClass.GetCheapestHotel("Pranton", 600))
            {
                    Console.WriteLine("The name of the cheapest hotel is Paradise");
            }
            else if (hotelReservationClass.GetCheapestHotel("Joseph", 800) < hotelReservationClass.GetCheapestHotel("Pranton", 600))
            {
                Console.WriteLine("The name of the cheapest hotel is Joseph");
            }
            else
            {
                Console.WriteLine("The name of the cheapest hotel is Pranton");
            }
            Console.ReadKey();
        }
    }
}
