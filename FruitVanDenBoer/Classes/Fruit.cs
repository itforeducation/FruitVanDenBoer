namespace Classes
{
    abstract class Fruit
    {
        double price;
        int amount, maxDiscount = 50, discountAmount = 5;

        public Fruit(int amount, int price)
        {
        }

        public double Calculate()
        {
            return price;
        }
    }
}
