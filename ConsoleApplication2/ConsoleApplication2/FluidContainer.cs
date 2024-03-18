using System;

namespace ConsoleApplication2
{
    public class FluidContainer : ContainerBase,IHazardNotifier
    {
        private Boolean isDanger;

        public FluidContainer(double weightOfload, double height, double containerWeight, double deepness,
            double serialNumber, double maxWeight) : base(weightOfload, height, containerWeight, deepness, serialNumber,
            maxWeight)
        {
            
        }
        public void informAboutDangerousSituation()
        {
            Console.WriteLine("Container "+serialNumber+" is in danger");
        }
        
        public void loadContainer( double MassToLoad, Boolean isDanger )
        {
            this.isDanger = isDanger;
            if (this.isDanger&&((containerWeight + MassToLoad)) < MaxWeight*0.5)
                containerWeight += MassToLoad;
            else if (!this.isDanger&&((containerWeight + MassToLoad)) < MaxWeight*0.9)
                containerWeight += MassToLoad;
            else
            {
                throw new OverFillException("Dangerous operation !!!");
            }
        }
    }
}