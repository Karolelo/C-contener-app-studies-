using System;

namespace ConsoleApplication2
{
    public class FluidContainer : ContainerBase, IHazardNotifier
    {
        private bool isDanger;

        public FluidContainer(double height, double containerWeight, double deepness,
             double maxWeight) : base(height, containerWeight, deepness, maxWeight)
        {
        }

        public void InformAboutDangerousSituation()
        {
            Console.WriteLine("Container " + serialNumber + " is in danger");
        }
        
        public void LoadContainer(Product product, bool isDanger)
        {
            this.isDanger = isDanger;
            double adjustedMaxWeight = isDanger ? maxWeight * 0.5 : maxWeight * 0.9;
            
            if ((product.wage + CalculateTotalWeight()) <= adjustedMaxWeight)
            {
                towars.Add(product);
            }
            else
            {
                informAboutDangerousSituation();
            }
        }

        public void informAboutDangerousSituation()
        {
            throw new OverFillException("Dangerous operation !!! "+serialNumber);
        }

        public override string ToString()
        {
            return $"Typ: Fluid Container, Numer Seryjny: {serialNumber}";
        }
    }
}