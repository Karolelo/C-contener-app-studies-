using System;

namespace ConsoleApplication2
{
    public class GasContainer : ContainerBase,IHazardNotifier
    {
        public double pressure;
        public GasContainer(double weightOfload, double height, double containerWeight,
                                double deepness, double serialNumber, double maxWeight,double pressure) 
            : base(weightOfload, height, containerWeight, deepness, serialNumber, maxWeight)
        {
            this.pressure = pressure;
        }
        public void UnloadContainer()
        {
            weightOfload = 0;
        }

        public void informAboutDangerousSituation()
        {
            Console.WriteLine("Container "+serialNumber+" is in danger");
        }
    }
}