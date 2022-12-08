using System;
using System.Collections.Generic;
using System.Reflection;

namespace CS.Reflection.Demo
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //  static or compile-time
            Type compileTimeTypeInfo = typeof(Car);

            //  runtime
            var car = new Car();
            Type runtimeTypeInfo = car.GetType();

            //  current executing type
            Type currentType = Assembly.GetExecutingAssembly().GetType("CS.Reflection.Demo.Program");

            //  arbitrary type information
            Type intTypeInfo = Type.GetType("System.Int32, System.Private.CoreLib");

            //  generic type
            Type genericDictionaryTypeInfo = typeof(Dictionary<,>);
            Type genericListTypeInfo = typeof(List<>);

            //  array type
            Type arrayTypeInfo = typeof(int[]);

            Type typeTypeInfo = typeof(Type);
        }
    }
}
