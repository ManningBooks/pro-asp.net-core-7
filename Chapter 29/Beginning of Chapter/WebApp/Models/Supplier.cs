namespace WebApp.Models {
    public class Supplier {

        public long SupplierId { get; set; }
        public required string Name { get; set; }
        public required string City { get; set; }

        public IEnumerable<Product>? Products { get; set; }
    }
}
