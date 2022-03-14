using System;

namespace ClassesIntro
{
    class Progam
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("First Car");
            Car anotherCar = new Car("Second Car");
            
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Brake();
            myCar.Accelerate();
            anotherCar.Brake();
        }
    }
    
    class Car
    {
        private int speed = 0;
        private string name;
        
        public Car(string carName)
        {
            name = carName;
        }
        
        public void Accelerate()
        {
            speed++;
            showSpeed();
        }
        
        public void Brake()
        {
            speed--;
            showSpeed();
        }
        
        private void showSpeed()
        {
            Console.WriteLine($"{name} is going {speed} MPH.");
        }
    }
}
