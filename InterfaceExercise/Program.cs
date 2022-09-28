using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car1 = new Car();
            car1.SmallTrunk = true;
            car1.SmallBody = true;
            car1.FourWheels = true;
            car1.Seats = true;
            car1.SeatBelts = true;
            car1.LicensePlates = true;
            car1.CompanyLogo = "An 'H' with a circle around it";
            car1.CompanyName = "Honda";

            var truck1 = new Truck();
            truck1.Bed = true;
            truck1.MadeForPulling = true;
            truck1.FourWheels = true;
            truck1.Seats = true;
            truck1.SeatBelts = true;
            truck1.LicensePlates = true;
            truck1.CompanyLogo = "A blue circle with 'ford' in the middle of it";
            truck1.CompanyName = "Ford";

            var suv1 = new SUV();
            suv1.FitsManyPeople = true;
            suv1.LargeTrunk = true;
            suv1.FourWheels = true;
            suv1.Seats = true;
            suv1.SeatBelts = true;
            suv1.LicensePlates = true;
            suv1.CompanyLogo = "A yellow plus with the two sides extended";
            suv1.CompanyName = "Chevrolet";

           

            do
            {
                Console.WriteLine("What vehicle would you like to examine? (Car/Truck/SUV)");
                var typeOfVehicleInput = Console.ReadLine().ToLower();

                if (typeOfVehicleInput == "car" || typeOfVehicleInput == "truck" || typeOfVehicleInput == "suv")
                {
                    if (typeOfVehicleInput == "car")
                    {
                        Console.WriteLine("Examining a car from a gas station parking lot: ");
                        car1.PrintInfo();
                        break;
                    }
                    else if (typeOfVehicleInput == "truck")
                    {
                        Console.WriteLine("Examining a truck from a gas station parking lot: ");
                        truck1.PrintInfo();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Examining a SUV from a gas station parking lot: ");
                        suv1.PrintInfo();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that's not an option... choose again:");

                }
            } while (true);

            






        }
    }
}
