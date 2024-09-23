namespace Admin.Models
{
    public class Stock
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }

        public Stock()
        {
            Products = new List<Product>();
            Categories = new List<Category>();
        }
        public void AddProductToStock(string name, double price, int count)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Product name cannot be empty");
            }

            Product product = new Product(name, price, count, 0); 
            Products.Add(product);
        }


        public void AddCategory(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Category category = new Category(name);
                Categories.Add(category);
            }
            else
            {
                throw new ArgumentException("Category name cannot be empty");
            }
        }


        public Category GetCategoryByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Category name cannot be empty");
            }

            var category = Categories.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (category == null)
            {
                throw new Exception($"Category '{name}' not found.");
            }
            return category;
        }


        public void AddProductToCategory(string categoryName, string productName, double price, int count)
        {
            if (string.IsNullOrEmpty(productName))
            {
                throw new ArgumentException("Product name cannot be empty");
            }


            Category category = GetCategoryByName(categoryName);

            if (category != null)
            {
                Product product = new Product(productName, price, count, category.Id);
                category.AddProduct(product);
                Products.Add(product);
            }
            else
            {
                throw new Exception("Category not found.");
            }
        }

    }
}
