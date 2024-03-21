using System.Collections.Generic;

namespace ConsoleApplication2
{
    public abstract class ContainerBase
    {
        public double WeightOfLoad => CalculateTotalWeight(); 
        
        public double Height { get; set; }
        
        public double ContainerWeight { get; set; }
        
        public double Deepness { get; set; }
        
        public string SerialNumber { get; set; }
        
        public double MaxWeight { get; set; }

        public List<Product> Towars { get; private set; }

        protected ContainerBase(double height, double containerWeight, double deepness, string serialNumber, double maxWeight)
        {
            Height = height;
            ContainerWeight = containerWeight;
            Deepness = deepness;
            SerialNumber = serialNumber;
            MaxWeight = maxWeight;
            Towars = new List<Product>();
        }

        public void UnloadContainer()
        {
            Towars.Clear(); 
        }

        public void LoadContainer(Product product)
        {
            if (( product.wage + CalculateTotalWeight()) <= MaxWeight)
                Towars.Add(product);
            else
                throw new OverFillException("Too much wage");
        }

        public double CalculateTotalWeight()
        {
            double totalWeight = 0;
            foreach (var product in Towars)
            {
                totalWeight += product.wage;
            }
            return totalWeight;
        }

        public override string ToString()
        {
            return SerialNumber;
        }
    }
}