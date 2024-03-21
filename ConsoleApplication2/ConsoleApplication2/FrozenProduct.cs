namespace ConsoleApplication2
{
    public class FrozenProduct : Product
    {
        public double tempretureForProduct { get; }

        public FrozenProduct(double wage, string name, double tempretureForProduct) : base(wage, name)
        {
            this.tempretureForProduct = tempretureForProduct;
        }

        public override string ToString()
        {
            return name + " tempreture for product " + tempretureForProduct;
        }
    }
}