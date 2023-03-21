using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            
            //TODO

            // Done -Create a seperate class file called Car
            //Done -Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done -Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //Done -The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var focus = new Car();
            focus.Make = "Ford";
            focus.Model = "Focus";
            focus.Year = 2013;
            focus.EngineNoise = "vroom";
            focus.HonkNoise = "beep";
            focus.IsDrivable = true;

            lot.Cars.Add(focus);

            var clarasCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDrivable = false
            };

            lot.Cars.Add(clarasCar);

            var myOtherCar = new Car(2013, "Honda", "Civic", "vrroom", "vruuuga", true);

            lot.Cars.Add(myOtherCar);

            focus.MakeEngineNoise(focus.EngineNoise);
            clarasCar.MakeEngineNoise(clarasCar.EngineNoise);
            myOtherCar.MakeEngineNoise(myOtherCar.EngineNoise);

            //*************BONUS*************//

            //Done - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Done -Create a CarLot class
            //Done -It should have at least one property: a List of cars
            //Done -Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //Done -At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach( var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}"); 
            }
        }
    }
}
