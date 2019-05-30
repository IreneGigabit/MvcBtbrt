namespace MvcBtbrt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cust_code
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Code_type { get; set; }

        [Key]
        [Column("Cust_code", Order = 1)]
        [StringLength(20)]
        public string Cust_code1 { get; set; }

        [StringLength(50)]
        public string Code_name { get; set; }

        public int? Sql { get; set; }

        [StringLength(2)]
        public string SortFld { get; set; }

        [StringLength(60)]
        public string form_name { get; set; }

        [StringLength(10)]
        public string Ref_code { get; set; }

        [StringLength(2)]
        public string Dept { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }

        [StringLength(1)]
        public string Mark { get; set; }

        [StringLength(30)]
        public string mark1 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? end_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tran_date { get; set; }
    }
}
