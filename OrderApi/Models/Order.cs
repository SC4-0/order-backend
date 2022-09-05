namespace OrderApi.Models
{
    public class Order
    {
        public long Id { get; set; }
        public string? CustomerId { get; set; }
        public string? ProductType { get; set; }
        public string? Scent1 { get; set; }
        public string? Scent2 { get; set; }
        public string? HolderColour { get; set; }
        public string? Message { get; set; }
        public int Quantity { get; set; }
    }
}