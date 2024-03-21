using System;

namespace ConsoleApplication2
{
    public class FluidContainer : ContainerBase, IHazardNotifier
    {
        private bool isDanger;

        public FluidContainer(double height, double containerWeight, double deepness,
            string serialNumber, double maxWeight) : base(height, containerWeight, deepness, serialNumber, maxWeight)
        {
        }

        public void InformAboutDangerousSituation()
        {
            Console.WriteLine("Container " + SerialNumber + " is in danger");
        }
        
        public void LoadContainer(Product product, bool isDanger)
        {
            this.isDanger = isDanger;
            double adjustedMaxWeight = isDanger ? MaxWeight * 0.5 : MaxWeight * 0.9;
            
            if ((product.wage + CalculateTotalWeight()) <= adjustedMaxWeight)
            {
                Towars.Add(product);
            }
            else
            {
                informAboutDangerousSituation();
            }
        }

        public void informAboutDangerousSituation()
        {
            throw new OverFillException("Dangerous operation !!!");
        }

        public override string ToString()
        {
            return $"Typ: Fluid Container, Numer Seryjny: {SerialNumber}";
        }
    }
}