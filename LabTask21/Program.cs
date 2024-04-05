namespace LabTask21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = { new Car("car1", 150, 20000), new Car("car2", 200, 30000), new Car("car3", 250, 35000) };

            Gallery gallery = new Gallery("gallery", cars);

            gallery.GetGalleryCarShow();
            Console.WriteLine("\n");
            gallery.GetGalleryCarById(2);
            Console.WriteLine("\n");
            Console.WriteLine(gallery.SumCar());
        }
    }
}
