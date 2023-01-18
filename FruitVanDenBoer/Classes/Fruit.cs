namespace Classes
{
    abstract class Fruit
    {
        double price;
        int amount, maxDiscount = 50, discountAmount = 5;

        public Fruit(int amount, double price)
        {
            this.amount = amount;
            this.price = price;
        }

        public double Calculate()
        {
            return price;
        }
    }
}
