using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class Ship
    {
        public List<ContainerBase> load;
        public String nameOfShip { get; set; }
        public int maxSpeed { get;set; }
        public int maxContainerInside { get; set; }
        
        public int actuallyQuanityOfContainers { get; set; }
        public int maxWageOfContainer { get; }
        
        public int acutallWage { get; }
        

        public Ship(string nameOfShip, int maxSpeed, int maxContainerInside, int maxWageOfContainer)
        {
            this.nameOfShip = nameOfShip;
            this.maxSpeed = maxSpeed;
            this.maxContainerInside = maxContainerInside;
            this.maxWageOfContainer = maxWageOfContainer;
            acutallWage = 0;
            actuallyQuanityOfContainers = 0;
            load = new List<ContainerBase>();
        }

        public List<ContainerBase> unload()
        {
            var tmp = load;
            load.Clear();
            return tmp;
        }

        

        public void LoadContainer(ContainerBase containerBase)
        {
            
            if ((actuallyQuanityOfContainers < maxContainerInside)&&((containerBase.weightOfLoad+containerBase.containerWeight)<maxWageOfContainer))
            {
                actuallyQuanityOfContainers += 1;
                load.Add(containerBase);
            }
            else
            {
                Console.WriteLine("not enough space");
            }
        }

        public void LoadContainers(List<ContainerBase> containerBases)
        {
            int size = containerBases.Count;
            double wageOfContainer = 0;
            containerBases.ForEach(e => wageOfContainer = (e.containerWeight + e.weightOfLoad));
            if ((actuallyQuanityOfContainers < maxContainerInside)&&(wageOfContainer<maxWageOfContainer))
            {
                load.AddRange(containerBases);
            }
            else
            {
                Console.WriteLine("not enough space");
            }
        }

        public ContainerBase GetContainer(String serialNumber)
        {
            return load.FirstOrDefault(container => container.serialNumber == serialNumber);
        }

        public ContainerBase ChangeContainer(String serialNumber,ContainerBase newContainer)
        {
            int index = load.FindIndex(container => container.serialNumber == serialNumber);
            
            if (index != -1)
            {
                var tmp = load[index];
                load[index] = newContainer;
                return tmp;
            }

            return null;
        }
        

        public void showContainerList()
        {
            Console.WriteLine(load);
        }
        public override string ToString()
        {
            
            var shipInfo = new StringBuilder($"Ship Name: {nameOfShip}\n");
            shipInfo.AppendLine($"Max Speed: {maxSpeed} knots");
            shipInfo.AppendLine($"Max Container Capacity: {maxContainerInside}");
            shipInfo.AppendLine($"Currently Loaded Containers: {actuallyQuanityOfContainers}");
            shipInfo.AppendLine($"Max Weight Per Container: {maxWageOfContainer}");
    
            
            shipInfo.AppendLine("Loaded Containers:");
            foreach (var container in load)
            {
                shipInfo.AppendLine($"- Container Serial: {container.serialNumber}, Weight of Load: {container.weightOfLoad}, Container Weight: {container.containerWeight}, Total Weight: {container.weightOfLoad + container.containerWeight}");
            }

            
            return shipInfo.ToString();
        }
        
    }        

}