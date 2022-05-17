using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy
{
    [Table("audiences")]
    class Audience
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("number")]
        public int Number { get; set; }

        [Column("frame")]
        public string Frame { get; set; }

        [Column("floor")]
        public int Floor { get; set; }

        [Column("audiencetype")]
        public string Audiencetype { get; set; }

        [Column("audienceowner")]
        public string Audienceowner { get; set; }

        [Column("square")]
        public int Square { get; set; }

        [Column("number_of_seats")]
        public int Number_of_seats { get; set; }

        [Column("category")]
        public string Category { get; set; }
    }
}
