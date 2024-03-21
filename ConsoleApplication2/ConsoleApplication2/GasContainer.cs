using System;
using System.Diagnostics.Eventing.Reader;

namespace ConsoleApplication2
{
    public class GasContainer : ContainerBase, IHazardNotifier
    {
        public Product towar;

        public int pressure;

        public GasContainer(double height, double containerWeight, double deepness,
            string serialNumber, double maxWeight,int pressure)
            : base(height, containerWeight, deepness, serialNumber, maxWeight)
        {
            this.pressure = pressure;
        }

        public void UnloadContainer()
        {
            double totalWeight = CalculateTotalWeight();
            double remainingWeight = totalWeight * 0.05;
            towars.Clear(); 
            
            if (remainingWeight > 0)
            {
                towars.Add(new Product( remainingWeight,"restOfGas"));
            }
        }

        public void LoadContainer(Product product)
        {
            if (product.wage < maxWeight)
            {
                towar = product;
            }
            else
            {
               informAboutDangerousSituation(); 
            }
        }

        public void informAboutDangerousSituation()
        {
            throw new OverFillException("Dangerous operation !!!"+serialNumber);
        }

       
        public override string ToString()
        {
            return $"Typ: Gas Container, Numer Seryjny: {serialNumber}, Ciśnienie: {pressure} atm";
        }
    }
}