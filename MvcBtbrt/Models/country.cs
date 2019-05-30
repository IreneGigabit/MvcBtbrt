namespace MvcBtbrt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("country")]
    public partial class country
    {
        [Key]
        [StringLength(5)]
        public string coun_code { get; set; }

        [StringLength(255)]
        public string coun_e { get; set; }

        [StringLength(255)]
        public string coun_c { get; set; }

        [StringLength(1)]
        public string cl { get; set; }

        [StringLength(10)]
        public string ccode { get; set; }

        [StringLength(20)]
        public string markc { get; set; }

        [StringLength(100)]
        public string buss_c { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tran_date { get; set; }

        [StringLength(5)]
        public string tran_scode { get; set; }

        [StringLength(20)]
        public string markb { get; set; }

        [StringLength(20)]
        public string markf { get; set; }
    }
}
