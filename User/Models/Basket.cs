using Admin.Models;
namespace User.Models
{
    public class Basket
    {
        public List<Product> Products { get; set; }

        public Basket()
        {
            Products = new List<Product>();
        }

        public double Hesab()
        {
            double hesab = 0;
            foreach (Product p in Products)
            {
                hesab += p.Price;
            }
            return hesab;
        }

        public void AddProductToBasket(Product product)
        {
            Products.Add(product);
        }

        public void ShowBasket()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine($"{product.Name}  {product.Price} azn");
            }
        }

        public void ClearBasket()
        {
            Products.Clear();
        }
    }
}
