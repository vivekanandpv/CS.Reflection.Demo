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
            var car = new Car();
            Type runtimeTypeInfo = car.GetType();

            //  fields
            FieldInfo[] fieldInfos = runtimeTypeInfo.GetFields();

            //  properties
            PropertyInfo[] propertyInfos = runtimeTypeInfo.GetProperties();

            //  methods
            MethodInfo[] methodInfos = runtimeTypeInfo.GetMethods();

            //  constructors
            ConstructorInfo[] constructorInfos = runtimeTypeInfo.GetConstructors();
        }
    }
}
