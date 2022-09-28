using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public bool FourWheels { get; set; }
        public bool Seats { get; set; }
        public bool SeatBelts { get; set; }
        public bool LicensePlates { get; set; }
    }
}
