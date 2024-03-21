using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static  void Main(string[] args)
        {

            ShippingService shp = new ShippingService();

            Ship ship=shp.CreateShip("as", 10, 10, 1000);

            FluidContainer test = new FluidContainer(10, 200, 12, 200);
            Product testproduct = new Product(100, "Banan");
            test.LoadContainer(testproduct);
            Console.WriteLine(test); 
            GasContainer test2 = new GasContainer(10, 200, 12, 200,50);
            Product testproduct2 = new Product(150, "Banan");
            test2.LoadContainer(testproduct2);
            Console.WriteLine(test2);
            

        }
    }
}