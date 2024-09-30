using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace City
{
    public class Building
    {

        public virtual void GetInfo()
        {
            Console.WriteLine($"Construct age: {constructAge}");
            Console.WriteLine($"Building price: {buildingPrice}");
        }
        static public void CheckPrice(Building building)
        {
            if (building.buildingPrice > reasonablePrice)
            {
                Console.WriteLine($"The price is too big! {building.buildingPrice}");
            }
            else
            {
                Console.WriteLine("The price is reasonable");
            }
        }
        static Building()
        {
            country = "America";
        }
        public Building()
        {
            constructAge = null;
            buildingPrice = null;
        }
        public Building(uint? age, uint? price)
        {
            constructAge = age;
            buildingPrice = price;
        }
        static public int reasonablePrice { get; set; } = 100000;
        static public string country { get; set; }
        public const string type = "Building";
        public uint? constructAge;
        public uint? buildingPrice;
    }
    public class Hospital : Building
    {
        public override void GetInfo()
        {
            Console.WriteLine($"Construct age: {constructAge}");
            Console.WriteLine($"Building price: {buildingPrice}");
            Console.WriteLine($"Capacity: {hospitalCapacity}");
            Console.WriteLine($"Workers Amount: {hospitalWorkersAmount}");
        }
        public Hospital()
        {
            constructAge = null;
            buildingPrice = null;
            hospitalCapacity = null;
            hospitalWorkersAmount = null;
        }
        public Hospital( uint? capacity, uint? workersAmount, Building building) : base(building.constructAge, building.buildingPrice)
        {
            hospitalCapacity = capacity;
            hospitalWorkersAmount = workersAmount;
        }
        public Hospital(uint? age, uint? price, uint? capacity, uint? workersAmount)
        {
            constructAge = age;
            buildingPrice = price;
            hospitalCapacity = capacity;
            hospitalWorkersAmount = workersAmount;
        }

        private uint? hospitalCapacity;
        private uint? hospitalWorkersAmount;
    }
}
