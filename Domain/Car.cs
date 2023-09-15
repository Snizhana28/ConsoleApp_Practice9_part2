using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice9_part2.Domain
{
    public class Car
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public Car(string name, string manufacturer, int year)
        {
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Manufacturer: {Manufacturer}, Year: {Year}";
        }
    }
}
