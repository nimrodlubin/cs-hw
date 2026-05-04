using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace Bank2
{
    class Aricraft
    {
        public string flightNumber { get; set; }
        public int altitude { get; set; }
        public Aricraft(string flightNumber, int altitude)
        {
            this.flightNumber = flightNumber;
            this.altitude = altitude;
        }
        public virtual void PrintStatus()
        {
            Console.WriteLine($"Flight Number: {flightNumber},\nAltitude: {altitude},");
        }
    }
    class PassengerPlane : Aricraft
    {
        int passengerCount { get; set; }
        public PassengerPlane(string flightNumber, int altitude, int passengerCount)
        : base(flightNumber, altitude)
        {
            this.passengerCount = passengerCount;
        }
        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"Passenger count: {passengerCount} ");
        }
    }
    class FighterJet : Aricraft
    {
        public bool missilesLoaded;
        public FighterJet(string flightNumber, int altitude, bool missilesLoaded)
        : base(flightNumber, altitude)
        {

        }
        public void FireMissile()
        {
            Console.WriteLine("Missile Fired!!");
            missilesLoaded = false;
        }
        public override void PrintStatus()
        {
            FireMissile();
        }
    }
}