namespace Supermarket
{
    public class ComposedProduct : Product
    {

        public float Discount { get; set; }

        public ICollection<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal total = 0;
            foreach (Product product in Products)
            {
                total += product.ValueToPay();
            }
            return total - (total * (decimal)Discount);
        }
        public override string ToString()
        {
            return $"{Id} - {Description}" +
            $"\n\tProduct ................: {$"{Products}",18}" +
            $"\n\tDiscount ...............: {$"{Discount:P2}",18}" +
            $"\n\tValue ..................: {$"{ValueToPay():C2}",18}";
        }
    }
}
