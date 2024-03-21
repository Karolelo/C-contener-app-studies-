using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class FrozzenContainer : ContainerBase
    {
        private List<FrozenProduct> products;
        public double Temperature { get; set; }

        public FrozzenContainer(double height, double containerWeight, double deepness, string serialNumber, double maxWeight, double temperature) 
            : base(height, containerWeight, deepness, serialNumber, maxWeight)
        {
            this.products = new List<FrozenProduct>();
            this.Temperature = temperature;
        }
        
        public void LoadContainer(FrozenProduct product)
        {
            if ((products[0].name==product.name && product.tempretureForProduct <= this.Temperature)||products.Count==0)
            {
                if (( product.wage + CalculateTotalWeight()) <= maxWeight)
                {
                    towars.Add(product);
                }
                else
                {
                    throw new OverFillException("Too much weight");
                }
            }
            else
            {
                throw new InvalidOperationException("Product type or temperature is not suitable for this container.");
            }
        }

        public override string ToString()
        {
            return $"Type: Frozen Container, Serial Number: {serialNumber}, Product Type: {products}, Temperature: {Temperature}";
        }
    }
}