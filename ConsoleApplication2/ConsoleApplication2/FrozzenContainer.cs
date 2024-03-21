using System;

namespace ConsoleApplication2
{
    public class FrozzenContainer : ContainerBase
    {
        public string TypeOfProduct { get; set; }
        public double Temperature { get; set; }

        public FrozzenContainer(double height, double containerWeight, double deepness, string serialNumber, double maxWeight, string typeOfProduct, double temperature) 
            : base(height, containerWeight, deepness, serialNumber, maxWeight)
        {
            this.TypeOfProduct = typeOfProduct;
            this.Temperature = temperature;
        }
        
        public void LoadContainer(Product product, string productType, double productTemperature)
        {
            if (productType == this.TypeOfProduct && productTemperature <= this.Temperature)
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
            return $"Type: Frozen Container, Serial Number: {serialNumber}, Product Type: {TypeOfProduct}, Temperature: {Temperature}";
        }
    }
}