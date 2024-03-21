using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
    public class ShippingService
    {
        private List<Ship> ships=new List<Ship>();
        
        public Ship CreateShip(string nameOfShip, int maxSpeed, int maxContainerInside, int maxWageOfContainer)
        {
            ships.Add(new Ship(nameOfShip, maxSpeed, maxContainerInside, maxWageOfContainer));
            return new Ship(nameOfShip, maxSpeed, maxContainerInside, maxWageOfContainer);
        }

       

        public void LoadProductIntoContainer(ContainerBase container, Product product)
        {
            container.LoadContainer(product);
        }

        public void LoadContainerOntoShip(Ship ship, ContainerBase container)
        {
            ship.LoadContainer(container);
        }

        public void LoadContainersOntoShip(Ship ship, List<ContainerBase> containers)
        {
            ship.LoadContainers(containers);
        }

        public ContainerBase RemoveContainerFromShip(Ship ship, string serialNumber)
        {
            ContainerBase container = ship.GetContainer(serialNumber);
            if (container != null)
            {
                ship.load.Remove(container);
                return container;
            }
            return null;
        }

        public void UnloadContainer(ContainerBase container)
        {
            container.UnloadContainer();
        }

        public ContainerBase ReplaceContainerOnShip(Ship ship, string serialNumber, ContainerBase newContainer)
        {
            return ship.ChangeContainer(serialNumber, newContainer);
        }

        public void TransferContainer(Ship fromShip, Ship toShip, string serialNumber)
        {
            ContainerBase container = RemoveContainerFromShip(fromShip, serialNumber);
            if (container != null)
            {
                try
                {
                    LoadContainerOntoShip(toShip, container);
                    
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine(ex.Message);
                   
                    LoadContainerOntoShip(fromShip, container);
                    
                }
            }
            
        }

        public void PrintContainerInfo(ContainerBase container)
        {
            Console.WriteLine(container);
        }

        public void PrintShipInfo(Ship ship)
        {
            Console.WriteLine(ship);
        }
    }
}