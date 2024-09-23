namespace Admin.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; } 
        public Category Category { get; set; } 

        
        public Product(string name, double price, int count, int categoryId)
        {
            Name = name;
            Price = price;
            Count = count;
            CategoryId = categoryId;
        }
            
    }
}
