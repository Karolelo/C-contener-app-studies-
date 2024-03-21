using System;

namespace ConsoleApplication2
{
    public class Product
    {
        public double wage { get; }
        
        public String name { get; }

        public Product(double wage, string name)
        {
            this.wage = wage;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
        
    }
}