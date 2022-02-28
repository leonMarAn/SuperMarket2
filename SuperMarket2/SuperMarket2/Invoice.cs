using SuperMarket2;

namespace Supermarket
{
    public class Invoice : IPay
    {

        private Product _products;

        public Invoice()
        {

        }

        public Invoice(Product products)
        {
            _products = products;
        }

        public void AddProduct(Product products)
        {
            ICollection<Product> Products = new List<Product>();
            Products.Add(products);
        }
        public decimal ValueToPay()
        {
            return _products.ValueToPay();
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
        $"\n\tValue .........: {$"{ValueToPay():C2}",18}";
        }

    }
}

