using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy
{
    [Table("software_lists")]
    class Software_list
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("manufacturer")]
        public string Manufacturer { get; set; }

        [Column("license")]
        public int License { get; set; }

        [Column("date_of_purchase")]
        public int Date_of_purchase { get; set; }

        [Column("license_expiration_date")]
        public int License_expiration_date { get; set; }

        [Column("in_which_classrooms")]
        public string In_which_classrooms { get; set; }
    }
}

