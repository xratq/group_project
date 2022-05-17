using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy
{
    [Table("educational_buildings")]
    class Educational_building
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("short_name")]
        public string Short_name { get; set; }

        [Column("adress")]
        public string Address { get; set; }
    }
}

