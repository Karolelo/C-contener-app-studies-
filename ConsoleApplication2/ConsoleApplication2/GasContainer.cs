using System;

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
            Towars.Clear(); 
            
            if (remainingWeight > 0)
            {
                Towars.Add(new Product( remainingWeight,"restOfGas"));
            }
        }

        public void LoadContainer(Product product)
        {
            if(product.wage>)
        }

        public void informAboutDangerousSituation()
        {
            throw new OverFillException("Dangerous operation !!!");
        }

       
        public override string ToString()
        {
            return $"Typ: Gas Container, Numer Seryjny: {SerialNumber}, Ciśnienie: {Pressure} atm";
        }
    }
}