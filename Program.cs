using System;
using System.Collections.Generic;
using System.Reflection;

namespace CS.Reflection.Demo
{
    [AttributeUsage(AttributeTargets.Property)]
    class PremiumAttribute : Attribute
    {
        public string Value { get; set; }
    }


    class Car
    {
        [Premium(Value = "Honda")]
        public string Make { get; set; }

        [Premium(Value = "City")]
        public string Model { get; set; }

        public int Year { get; set; }

        [Premium(Value = "Silver")]
        public string Color { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            Type typeInfo = car.GetType();

            PropertyInfo[] properties = typeInfo.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var attributeInstance = property.GetCustomAttribute<PremiumAttribute>();

                if (attributeInstance != null)
                {
                    Console.WriteLine($"Property: {property.Name} --> {attributeInstance.Value}");
                }
            }
        }
    }
}
