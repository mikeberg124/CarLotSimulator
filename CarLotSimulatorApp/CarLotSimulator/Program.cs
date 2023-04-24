using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE- Create a seperate class file called Car
            //DONE-Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE-Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE-The methods should take one string parameter: the respective noise property

            //DONE-Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();
           


            //Now that the Car class is created we can instanciate 3 new cars
            var myCar = new Car();
            myCar.Make = "Porsche";
            myCar.Model = "GT3 RS";
            myCar.Year = 2021;
            myCar.EngineNoise = "vroom";
            myCar.HonkNoise = "beepbeep";
            myCar.IsDriveable = true;

            lot.Cars.Add(myCar);


           var myCar2 = new Car()
            {
                Model = "Civic",
                Make = "Honda",
                Year = 2022,
                EngineNoise = "beep",
                HonkNoise = "squeek",
                IsDriveable = true
            };
            lot.Cars.Add(myCar2);

            var myCar3 = new Car(2019, "Tesla", "Y", "woosh", "beep", false);
            
            lot.Cars.Add(myCar3);



            //DONE- Set the properties for each of the cars
            //DONE-Call each of the methods for each car

            myCar.MakesEngineNoise(myCar.EngineNoise);
            myCar2.MakesEngineNoise(myCar2.EngineNoise);
            myCar3.MakesEngineNoise(myCar3.EngineNoise);


            //*************BONUS*************//

            // DONE- set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE- Create a CarLot class
            //DONE-It should have at least one property: a List of cars

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");


            foreach (var car in lot.Cars)
            {


                Console.WriteLine($"Year:{car.Year} Make: {car.Make} Model:{car.Model}");


            }


            
        }
        


    }
}
