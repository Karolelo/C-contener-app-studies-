using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
    public class Ship
    {
        public List<ContainerBase> load;
        public String nameOfShip { get; set; }
        public int maxSpeed { get;set; }
        public int maxContainerInside { get; set; }
        
        public int actuallyQuanityOfContainers { get; set; }

        public Ship(string nameOfShip, int maxSpeed, int maxContainerInside)
        {
            this.nameOfShip = nameOfShip;
            this.maxSpeed = maxSpeed;
            this.maxContainerInside = maxContainerInside;
            actuallyQuanityOfContainers = 0;
        }

        public Ship(string nameOfShip)
        {
            this.nameOfShip = nameOfShip;
            load = new List<ContainerBase>();
        }

        public void LoadContainer(ContainerBase containerBase)
        {
            if (actuallyQuanityOfContainers < maxContainerInside)
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
            if (actuallyQuanityOfContainers+size < maxContainerInside)
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
    }        

}