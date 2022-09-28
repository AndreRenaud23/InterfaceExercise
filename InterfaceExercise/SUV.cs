using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool FitsManyPeople { get; set; }
        public bool LargeTrunk { get; set; }
        public bool FourWheels { get; set; }
        public bool Seats { get; set; }
        public bool SeatBelts { get; set; }
        public bool LicensePlates { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyName { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Fits many people: {FitsManyPeople}");
            Console.WriteLine($"Has a large trunk: {LargeTrunk}");
            Console.WriteLine($"Has four wheels: {FourWheels}");
            Console.WriteLine($"Has seats: {Seats}");
            Console.WriteLine($"Has seat belts: {SeatBelts}");
            Console.WriteLine($"Has License plates: {LicensePlates}");
            Console.WriteLine($"Company logo: {LicensePlates}");
            Console.WriteLine($"Company name: {CompanyName}");
        }
    }
}
