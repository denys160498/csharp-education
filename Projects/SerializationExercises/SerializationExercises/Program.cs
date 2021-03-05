using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(2342, "Toyota", "Camry");
            Car restoredCarFromBin = null;
            Car restoredCarFromJson = null;
            string fileToStoreCarBin = @"D:\sandboxes\csharp-education\output\car.dat";
            string fileToStoreCarJson = @"D:\sandboxes\csharp-education\output\car.json";

            Console.WriteLine("Car1:");
            car1.Display();

            BinarySerialize<Car>(car1, fileToStoreCarBin);
            BinaryDeserialize<Car>(out restoredCarFromBin, fileToStoreCarBin);

            JsonSerialize<Car>(car1, fileToStoreCarJson);
            JsonDeserialize<Car>(out restoredCarFromJson, fileToStoreCarJson);

            Console.WriteLine("Binary Restored Car:");
            restoredCarFromBin.Display();

            Console.WriteLine("Json Restored Car:");
            restoredCarFromJson.Display();
        }

        static void BinarySerialize<T>(T obj, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }

        static void BinaryDeserialize<T>(out T obj, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                obj = (T)formatter.Deserialize(fs);
            }
        }

        static void JsonSerialize<T>(T obj, string filePath)
        {
            using StreamWriter sw = new StreamWriter(filePath);
            string json = JsonConvert.SerializeObject(obj);
            sw.Write(json);
        }

        static void JsonDeserialize<T>(out T obj, string filePath)
        {
            using StreamReader sr = new StreamReader(filePath);
            string json = sr.ReadToEnd();
            obj = JsonConvert.DeserializeObject<T>(json);
        }
    }

}
