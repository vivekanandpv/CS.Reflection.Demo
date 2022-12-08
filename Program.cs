using System;
using System.Collections.Generic;
using System.Reflection;

namespace CS.Reflection.Demo
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public void Drive(int distance)
        {
            Console.WriteLine($"Car is driving for {distance} km");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Type typeInfo = typeof(Car);

            //  activation
            Car car = (Car)Activator.CreateInstance(typeInfo, "Honda", "City");

            //  invoke
            MethodInfo methodInfo = typeInfo.GetMethod("Drive");
            methodInfo.Invoke(car, new object[] { 145 });
        }
    }
}
