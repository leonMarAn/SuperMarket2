
using SuperMarket2;

namespace Supermarket
{
    public abstract class Product : IPay
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public abstract decimal ValueToPay();

        internal void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
        $"{Id} - {Description}" +
        $"\n\tPrice .................: {$"{Price:C2}",18}" +
        $"\n\tTax ...................: {$"{Tax:P2}",18}";
        }
    }
}

