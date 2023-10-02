using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4._4
{
 
    public interface IGeographicObject
    {
        double X { get; set; }
        double Y { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        string GetInformation();
    }

    public class GeographicObject : IGeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GeographicObject(double x, double y, string name, string description)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
        }

        public virtual string GetInformation()
        {
            return $"Name: {Name}\n Coordinate (X, Y): ({X}, {Y})\n Description: {Description}";
        }
    }

    public class River : IGeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double FlowSpeed { get; set; }
        public double TotalLength { get; set; }

        public River(double x, double y, string name, string description, double flowSpeed, double totalLength)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            FlowSpeed = flowSpeed;
            TotalLength = totalLength;
        }

        public string GetInformation()
        {
            return $"Name: {Name}\n Coordinate: ({X}, {Y})\n Description: {Description}\n Flow speed: {FlowSpeed} cm/s\n Total length: {TotalLength} km";
        }
    }

    // Клас "Гора" на основі інтерфейсу
    public class Mountain : IGeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double HighestPoint { get; set; }

        public Mountain(double x, double y, string name, string description, double highestPoint)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            HighestPoint = highestPoint;
        }

        public string GetInformation()
        {
            return $"Name: {Name}\n Coordinate: ({X}, {Y})\n Description: {Description}\n The highest point: {HighestPoint} m";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            IGeographicObject tiberRiver = new River(41.90, 12.50, "Tiber", "The third-longest river in Italy", 50, 406);
            IGeographicObject marmoladaMountain = new Mountain(46.43, 11.86, "Marmolada", "The highest mountain in the Dolomites", 3343);

            Console.WriteLine("Information about the Tiber River:");
            Console.WriteLine(tiberRiver.GetInformation());

            Console.WriteLine("\nInformation about the Marmolada Mountain:");
            Console.WriteLine(marmoladaMountain.GetInformation());

            Console.ReadKey();
        }
    }

}
