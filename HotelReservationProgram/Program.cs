using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Welcome to Hotel Registration Program");
            HotelReservationClass hotelReservationClass = new HotelReservationClass();
            //hotelReservationClass.AddHotelName("Paradise", 800);
            //hotelReservationClass.AddHotelName("Joseph", 1000);
            //hotelReservationClass.AddHotelName("Pranton", 600);
            if(hotelReservationClass.GetCheapestHotel("Paradise", 800, 1000) < hotelReservationClass.GetCheapestHotel("Joseph", 1000, 1200) && hotelReservationClass.GetCheapestHotel("Paradise", 800, 1000) < hotelReservationClass.GetCheapestHotel("Pranton", 600, 800))
            {
                    Console.WriteLine("The name of the cheapest hotel is Paradise");
            }
            else if (hotelReservationClass.GetCheapestHotel("Joseph", 800, 1000) < hotelReservationClass.GetCheapestHotel("Pranton", 600, 800))
            {
                Console.WriteLine("The name of the cheapest hotel is Joseph");
            }
            else
            {
                Console.WriteLine("The name of the cheapest hotel is Pranton");
            }
            Console.ReadKey();
=======
            Console.WriteLine("Welcome to the Hotel Reservation Program");
>>>>>>> UC2-FindCheapestHotel
        }
    }
}
