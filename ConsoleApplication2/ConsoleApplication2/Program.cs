using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static  void Main(string[] args)
        {

            ShippingService shp = new ShippingService();

            shp.CreateShip("as", 10, 10, 1000);



        }
    }
}