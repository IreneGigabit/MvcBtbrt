namespace MvcBtbrt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class apcust_attach
    {
        [Key]
        [StringLength(10)]
        public string apattach_sqlno { get; set; }

        public int? apsqlno { get; set; }

        [Required]
        [StringLength(1)]
        public string cust_area { get; set; }

        public int? cust_seq { get; set; }

        [Required]
        [StringLength(10)]
        public string source { get; set; }

        public DateTime in_date { get; set; }

        [Required]
        [StringLength(5)]
        public string in_scode { get; set; }

        [Required]
        [StringLength(10)]
        public string in_prgid { get; set; }

        [StringLength(30)]
        public string contract_no { get; set; }

        [StringLength(5)]
        public string sign_flag { get; set; }

        [StringLength(5)]
        public string company { get; set; }

        [StringLength(2)]
        public string dept { get; set; }

        [StringLength(5)]
        public string country { get; set; }

        [StringLength(5)]
        public string sign_scode { get; set; }

        [StringLength(5)]
        public string agt_no { get; set; }

        [StringLength(4)]
        public string agent_no { get; set; }

        [StringLength(1)]
        public string agent_no1 { get; set; }

        public int? attach_no { get; set; }

        [StringLength(300)]
        public string attach_path { get; set; }

        [StringLength(5)]
        public string doc_type { get; set; }

        [StringLength(300)]
        public string attach_desc { get; set; }

        [StringLength(100)]
        public string attach_name { get; set; }

        [StringLength(100)]
        public string source_name { get; set; }

        public decimal? attach_size { get; set; }

        [StringLength(1)]
        public string attach_flag { get; set; }

        [StringLength(100)]
        public string stop_remark { get; set; }

        [StringLength(2)]
        public string main_dept { get; set; }

        public int? main_seq { get; set; }

        [StringLength(3)]
        public string main_seq1 { get; set; }

        [StringLength(30)]
        public string mcontract_no { get; set; }

        [StringLength(200)]
        public string mremark { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? use_dates { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? use_datee { get; set; }

        [Column(TypeName = "text")]
        public string remark { get; set; }

        [StringLength(1)]
        public string mark { get; set; }

        public DateTime tran_date { get; set; }

        [Required]
        [StringLength(5)]
        public string tran_scode { get; set; }

        [Required]
        [StringLength(10)]
        public string tran_prgid { get; set; }
    }
}
