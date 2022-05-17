using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy
{
    [Table("additional_characteristics")]
    class Additional_characteristic
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        [Column("characteristic")]
        public string Characteristic { get; set; }

        [Column("meaning")]
        public string Meaning { get; set; }
    }
}
