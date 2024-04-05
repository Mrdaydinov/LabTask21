using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask21
{
    internal class Gallery
    {
        public string Name { get; set; }
        private Car[] Cars { get; set; }

        public Gallery(string name, Car[] cars)
        {
            Name = name;
            Cars = cars;
        }

        public void GetGalleryCarShow()
        {
            foreach (var car in Cars)
            {
                car.GetInfoCar();
            }
        }

        public void GetGalleryCarById(int id) 
        {
            foreach (var car in Cars)
            {
                if (car.Id == id)
                    car.GetInfoCar();
            }
        }

        public decimal SumCar() 
        {
            decimal sum = 0;
            foreach (var car in Cars)
            {
                sum += car.Price;
            }

            return sum;
        }
    }
}
