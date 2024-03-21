using System.Collections.Generic;

namespace ConsoleApplication2
{
    public abstract class ContainerBase
    {
        public double weightOfLoad => CalculateTotalWeight(); 
        
        public double height { get; set; }
        
        public double containerWeight { get; set; }
        
        public double deepness { get; set; }
        
        public string serialNumber { get; set; }
        
        public double maxWeight { get; set; }

        public List<Product> towars { get; private set; }

        protected ContainerBase(double height, double containerWeight, double deepness, string serialNumber, double maxWeight)
        {
            this.height = height;
            this.containerWeight = containerWeight;
            this.deepness = deepness;
            this.serialNumber = serialNumber;
            this.maxWeight = maxWeight;
            towars = new List<Product>();
        }

        public void UnloadContainer()
        {
            towars.Clear(); 
        }

        public void LoadContainer(Product product)
        {
            if (( product.wage + CalculateTotalWeight()) <= maxWeight)
                towars.Add(product);
            else
                throw new OverFillException("Too much wage");
        }

        public double CalculateTotalWeight()
        {
            double totalWeight = 0;
            foreach (var product in towars)
            {
                totalWeight += product.wage;
            }
            return totalWeight;
        }

        public override string ToString()
        {
            return serialNumber;
        }
    }
}