using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy
{
    [Table("equiment_lists")]
    class Equipment_list
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("inventory_number")]
        public int Inventory_number { get; set; }

        [Column("serial_number")]
        public int Serial_number { get; set; }

        [Column("date_of_purchase")]
        public int Date_of_purchase { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("amount")]
        public int Amount { get; set; }

        [Column("where_used")]
        public string Where_used { get; set; }

        [Column("category")]
        public string Category { get; set; }

        [Column("in_the_audience_is")]
        public string In_the_audience_is { get; set; }
    }
}
