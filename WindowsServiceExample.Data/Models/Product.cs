using System;

namespace WindowsServiceExample.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public double? Price { get; set; }
        public DateTimeOffset? PurchaseDate { get; set; }
        public DateTime DateInserted { get; set; }
        public Product()
        {
            Id = Guid.NewGuid();
            DateInserted = DateTime.Now;
        }
    }
}
