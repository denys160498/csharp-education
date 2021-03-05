using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;

namespace SerializationExercises
{
    [Serializable]
    class Car
    {
        public int SerialNo { get; private set; }
        public string Mark { get; private set; }
        public string Model { get; private set; }

        private int amountOfPassengers;

        [JsonConstructor]
        public Car(int serialNo, string mark, string model, int amountOfPassengers = 5)
        {
            SerialNo = serialNo;
            Mark = mark;
            Model = model;
            this.amountOfPassengers = amountOfPassengers;
        }

        public void Display()
        {
            Console.WriteLine($"Serial Number: {SerialNo}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Capability of passengers: {amountOfPassengers}");
            Console.WriteLine('\n');
        }
    }
}
