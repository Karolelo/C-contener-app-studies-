using System;

namespace ConsoleApplication2
{

    public abstract class ContainerBase
    {
        public double weightOfload { get; set; }
        
        public double height { get; set; }
        
        public double containerWeight { get; set; }
        
        public double deepness { get; set; }
        
        public double serialNumber { get; set; }
        
        public double MaxWeight { get; set; }

        protected ContainerBase(double weightOfload, double height, double containerWeight, double deepness, double serialNumber, double maxWeight)
        {
            this.weightOfload = weightOfload;
            this.height = height;
            this.containerWeight = containerWeight;
            this.deepness = deepness;
            this.serialNumber = serialNumber;
            MaxWeight = maxWeight;
        }

        public void UnloadContainer()
        {
            weightOfload = 0;
        }

        public void loadContainer( double MassToLoad )
        {
            if ((containerWeight + MassToLoad) < MaxWeight)
                containerWeight += MassToLoad;
            else
                throw new OverFillException("Too much wage");
            
        }
       
    }
}