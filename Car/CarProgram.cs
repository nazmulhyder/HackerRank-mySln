using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class CarProgram
    {
        int carMaxSpeed = 100;
        int carMinSpeed = 0;

        double carWeight = 4096;
        Boolean isCarOn = false;
        char carCondition = 'A';
        string carName = "Lamborghini";

        int maxFuel = 16;
        int currentFuel = 8;
        double milesPerGallon = 26.4;

        int numberOfPeopleInTheCar = 1;
        int maxNumberOfPeopleInCar = 6;

        CarProgram()
        {

        }
        public CarProgram(int customCarMaxSpeed,int customCarMinSpeed,Boolean istheCarOn)
        {
            carMaxSpeed = customCarMaxSpeed;
            carMinSpeed = customCarMinSpeed;
            isCarOn = istheCarOn;

        }

        void printAllVeriable()
        {
            Console.WriteLine();
        }
        public void GetIn()
        {
            //if the number of people is less then the max number of people in the car
            if (numberOfPeopleInTheCar<maxNumberOfPeopleInCar)
            {
                //then, someone tell get in the car
                numberOfPeopleInTheCar++;
                Console.WriteLine("someone get in");
                Console.ReadLine();
            }
            else
            {
                // if the number of people is equal to the max number of people in the car
                //we'll print that.
                Console.WriteLine("the car is full,"+numberOfPeopleInTheCar+" = "+maxNumberOfPeopleInCar);
                Console.ReadLine();
            }

        }
        public void GetOut()
        {
            // if the number of people is more than 0
            // then, someone tell to get out
            if (numberOfPeopleInTheCar>0)
            {
                numberOfPeopleInTheCar --;
            }
            else
            {
                //if,no one is in the car, we'll print that.
                Console.WriteLine("no one is in the car");
                Console.ReadLine();
            }
            
        }

        public double howManyMilesTillOutofGas()
        {
            return currentFuel * milesPerGallon;
        }
        public double maxMilesForFillUp()
        {
            return maxFuel * milesPerGallon;
        }

        void turnTheCarOn()
        {
            //if the car is't on ....
            if (!isCarOn)
            {
                //turn it on
                isCarOn = true;
            }
            else
            {
                Console.WriteLine("the car is already open "+isCarOn);
                Console.ReadLine();
            }
            
        }

        public static void Main(String[] args)
        {

            CarProgram firstNewCar = new CarProgram();
            firstNewCar.GetOut();
            firstNewCar.GetOut();
            firstNewCar.GetIn();
            firstNewCar.GetIn();
            firstNewCar.GetIn();
            firstNewCar.GetIn();
            firstNewCar.GetIn();
            firstNewCar.GetIn();
            firstNewCar.GetIn();
            firstNewCar.GetIn();
            firstNewCar.GetIn();
            firstNewCar.turnTheCarOn();
            firstNewCar.turnTheCarOn();


        }
    }
}
