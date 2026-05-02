using System;
using System.Collections.Generic;
using System.Text;



namespace FlightReservationSystem
{
    class Booking
    {
        public string FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public TravelClass TravelClass { get; set; }
        public Passenger Passenger { get; set; }

        public Booking(string flight, DateTime date, TravelClass tClass, Passenger p)
        {
            FlightNumber = flight;
            DepartureDate = date;
            TravelClass = tClass;
            Passenger = p;
        }
    }
}
