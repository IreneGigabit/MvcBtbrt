namespace MvcBtbrt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class custz_att
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string cust_area { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cust_seq { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short att_sql { get; set; }

        [StringLength(1)]
        public string dept { get; set; }

        [StringLength(60)]
        public string attention { get; set; }

        [StringLength(60)]
        public string att_company { get; set; }

        [StringLength(40)]
        public string att_title { get; set; }

        [StringLength(40)]
        public string att_dept { get; set; }

        [StringLength(4)]
        public string att_tel0 { get; set; }

        [StringLength(15)]
        public string att_tel { get; set; }

        [StringLength(10)]
        public string att_tel1 { get; set; }

        [StringLength(30)]
        public string att_mobile { get; set; }

        [StringLength(20)]
        public string att_fax { get; set; }

        [StringLength(8)]
        public string att_zip { get; set; }

        [StringLength(60)]
        public string att_addr1 { get; set; }

        [StringLength(60)]
        public string att_addr2 { get; set; }

        [StringLength(100)]
        public string att_email { get; set; }

        [StringLength(1)]
        public string att_mag { get; set; }

        [StringLength(2)]
        public string att_code { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ttran_date { get; set; }

        [StringLength(5)]
        public string ttran_scode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ptran_date { get; set; }

        [StringLength(5)]
        public string ptran_scode { get; set; }

        [StringLength(1)]
        public string mark { get; set; }
    }
}
