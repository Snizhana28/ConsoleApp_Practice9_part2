using ConsoleApp_Practice9_part2.Domain;
using System;

namespace ConsoleApp_Practice9_part2.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars1 = new List<Car>
            {
                new Car("BMW", "Germany", 2010),
                new Car("Audi", "Germany", 2011),
                new Car("Toyota", "Japan", 2018),
            };

            var cars2 = new List<Car>
            {
                new Car("Audi", "Germany", 2011),
                new Car("Mercedes", "Germany", 2012),
                new Car("Ford", "USA", 2015),
            };

            var difference = cars1.Except(cars2, new CarComparer());
            var intersection = cars1.Intersect(cars2, new CarComparer());
            var union = cars1.Union(cars2, new CarComparer());

            Console.WriteLine("Array difference: ");
            foreach (Car car in difference)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("Array intersection: ");
            foreach (Car car in intersection)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("Array union: ");
            foreach (Car car in union)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}