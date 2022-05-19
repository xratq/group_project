namespace TodoApi.Models
{
    public class Equipment_list
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public int Inventory_number { get; set; }

        public int Serial_number { get; set; }

        public int Date_of_purchase { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public string? Where_used { get; set; }

        public string? Category { get; set; }

        public string? In_the_audience_is { get; set; }
    }
}
