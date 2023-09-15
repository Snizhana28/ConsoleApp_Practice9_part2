using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice9_part2.Domain
{
    public class CarComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car x, Car y)
        {
            return x.Manufacturer == y.Manufacturer;
        }

        public int GetHashCode(Car car)
        {
            return car.Manufacturer.GetHashCode();
        }
    }
}
