using System;
using System.Collections.Generic;
using System.Reflection;

namespace CS.Reflection.Demo
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    class PremiumAttribute : Attribute
    {
        public int Value { get; set; }
    }


    class Car
    {
        [Premium(Value = 458)]
        public string Make { get; set; }

        public string Model { get; set; }

        

        public void Drive(int distance)
        {
            Console.WriteLine($"Car is driving for {distance} km");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            Type typeInfo = car.GetType();

            //  custom attributes
            PropertyInfo propertyInfo = typeInfo.GetProperty("Make");
            PremiumAttribute premiumAttributeInstance = propertyInfo.GetCustomAttribute<PremiumAttribute>();
        }
    }
}
