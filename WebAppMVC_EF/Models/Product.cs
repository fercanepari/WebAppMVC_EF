namespace WebAppMVC_EF.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        public Product()
        {

        }
    }
}
