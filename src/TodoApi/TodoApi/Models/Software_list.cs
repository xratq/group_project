namespace TodoApi.Models
{
    public class Software_list
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public string? Manufacturer { get; set; }

        public int License { get; set; }

        public int Date_of_purchase { get; set; }

        public int License_expiration_date { get; set; }

        public string? In_which_classrooms { get; set; }
    }
}
