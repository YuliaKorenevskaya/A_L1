using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_L1
{
    public class Product
    {
        public int ProductID { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public double Material { get; set; }
        public double Weight { get; set; }
        public virtual void Sale (int percent)
        {
            this.Price = Price - Price / 100 * percent;
        }
    }

    public class Backpack : Product
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public double Volume { get; set; }
        public override void Sale(int percent)
        {
            if (Year<2019)
            {
                percent = 75;
                this.Price = Price - Price / 100 * percent;
            }     
        }
    }
    public class TouristBackpack : Backpack
    {
    }
    public class BicycleBackpack : Backpack
    {
    }
    public class Tent : Product
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DesignType { get; set; }
        public int Capacity { get; set; }
        public override void Sale(int percent)
        {
            this.Price = Price;
        }
    }
    public class Sleepingbag : Product
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public override void Sale(int percent)
        {
            if (Color == "green")
            {
                percent = 5;
                this.Price = Price - Price / 100 * percent;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TouristBackpack saturn = new TouristBackpack();
            Console.ReadKey();
        }
    }
}