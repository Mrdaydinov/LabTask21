using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask21
{
    internal class Car
    {
        public int Id { get; set; }
        private static int Count { get; set; } = 0;
        string Name { get; set; }
        int Speed { get; set; }
        public decimal Price { get; set; }

        public Car(string name, int speed, decimal price)
        {
            Name = name;
            Speed = speed;
            Price = price;
            Id = ++Count;
        }

        public void GetInfoCar()
        {
            Console.WriteLine($"Id = {Id}, Name = {Name}, Speed = {Speed}, Price = {Price}");
        }
    }
}
