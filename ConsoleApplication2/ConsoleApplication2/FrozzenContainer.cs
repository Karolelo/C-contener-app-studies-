using System;

namespace ConsoleApplication2
{
    public class FrozzenContainer : ContainerBase
    {
        public String typeOfProduct { set; get; }
        public double tempreature { set; get; }

        public FrozzenContainer(double weightOfload, double height, double containerWeight, double deepness, double serialNumber, double maxWeight, string typeOfProduct, double tempreature) : base(weightOfload, height, containerWeight, deepness, serialNumber, maxWeight)
        {
            this.typeOfProduct = typeOfProduct;
            this.tempreature = tempreature;
        }
    }
}