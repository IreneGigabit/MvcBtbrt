namespace MvcBtbrt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("custz")]
    public partial class custz
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string cust_area { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cust_seq { get; set; }

        [StringLength(10)]
        public string id_no { get; set; }

        [StringLength(100)]
        public string www { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(4)]
        public string con_code { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? con_term { get; set; }

        [StringLength(8)]
        public string acc_zip { get; set; }

        [StringLength(60)]
        public string acc_addr1 { get; set; }

        [StringLength(60)]
        public string acc_addr2 { get; set; }

        [StringLength(4)]
        public string acc_tel0 { get; set; }

        [StringLength(10)]
        public string acc_tel { get; set; }

        [StringLength(10)]
        public string acc_tel1 { get; set; }

        [StringLength(20)]
        public string acc_fax { get; set; }

        [StringLength(4)]
        public string rmark_code { get; set; }

        public int? ref_seq { get; set; }

        [StringLength(8)]
        public string ref_no { get; set; }

        [StringLength(1)]
        public string mag { get; set; }

        [StringLength(5)]
        public string pscode { get; set; }

        [StringLength(1)]
        public string plevel { get; set; }

        [StringLength(3)]
        public string pdis_type { get; set; }

        [StringLength(3)]
        public string ppay_type { get; set; }

        [StringLength(5)]
        public string tscode { get; set; }

        [StringLength(1)]
        public string tlevel { get; set; }

        [StringLength(3)]
        public string tdis_type { get; set; }

        [StringLength(3)]
        public string tpay_type { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dmt_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ext_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dmp_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? exp_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? in_date { get; set; }

        [StringLength(5)]
        public string in_scode { get; set; }

        [StringLength(2)]
        public string tran_code { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ttran_date { get; set; }

        [StringLength(5)]
        public string ttran_scode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ptran_date { get; set; }

        [StringLength(5)]
        public string ptran_scode { get; set; }

        [Column(TypeName = "text")]
        public string cust_remark { get; set; }

        [StringLength(1)]
        public string mark { get; set; }

        [StringLength(100)]
        public string tran_remark { get; set; }

        [StringLength(100)]
        public string tran_ctrl { get; set; }

        public DateTime? tran_output { get; set; }

        public DateTime? tran_upmail { get; set; }

        [StringLength(100)]
        public string pacc_email { get; set; }

        [StringLength(100)]
        public string tacc_email { get; set; }

        [StringLength(8)]
        public string tacc_zip { get; set; }

        [StringLength(60)]
        public string tacc_addr1 { get; set; }

        [StringLength(60)]
        public string tacc_addr2 { get; set; }

        [StringLength(4)]
        public string tacc_tel0 { get; set; }

        [StringLength(10)]
        public string tacc_tel { get; set; }

        [StringLength(10)]
        public string tacc_tel1 { get; set; }

        [StringLength(20)]
        public string tacc_fax { get; set; }

        [StringLength(500)]
        public string acc_remark { get; set; }

        [StringLength(2)]
        public string pspay_flag { get; set; }

        public short? pspay_mm { get; set; }

        [StringLength(2)]
        public string tspay_flag { get; set; }

        public short? tspay_mm { get; set; }

        [StringLength(10)]
        public string pacc_chkcode { get; set; }

        [StringLength(10)]
        public string tacc_chkcode { get; set; }

        [StringLength(60)]
        public string pacc_attention { get; set; }

        [StringLength(40)]
        public string pacc_title { get; set; }

        [StringLength(60)]
        public string tacc_attention { get; set; }

        [StringLength(40)]
        public string tacc_title { get; set; }

        [StringLength(8)]
        public string tax_zip { get; set; }

        [StringLength(60)]
        public string tax_addr1 { get; set; }

        [StringLength(60)]
        public string tax_addr2 { get; set; }

        [StringLength(4)]
        public string tax_tel0 { get; set; }

        [StringLength(10)]
        public string tax_tel { get; set; }

        [StringLength(10)]
        public string tax_tel1 { get; set; }

        [StringLength(20)]
        public string tax_fax { get; set; }

        [StringLength(2)]
        public string payout_mark { get; set; }

        public int? tpay_typem { get; set; }

        public int? ppay_typem { get; set; }

        [StringLength(20)]
        public string pspay_source { get; set; }

        [StringLength(15)]
        public string pspay_seq { get; set; }

        [StringLength(50)]
        public string pspay_refno { get; set; }

        [StringLength(20)]
        public string tspay_source { get; set; }

        [StringLength(15)]
        public string tspay_seq { get; set; }

        [StringLength(50)]
        public string tspay_refno { get; set; }

        [StringLength(60)]
        public string tax_attention { get; set; }

        [StringLength(100)]
        public string tax_email { get; set; }

        [StringLength(60)]
        public string taxacc_attention { get; set; }

        [StringLength(100)]
        public string taxacc_email { get; set; }

        [StringLength(8)]
        public string taxacc_zip { get; set; }

        [StringLength(60)]
        public string taxacc_addr1 { get; set; }

        [StringLength(60)]
        public string taxacc_addr2 { get; set; }

        [StringLength(4)]
        public string taxacc_tel0 { get; set; }

        [StringLength(10)]
        public string taxacc_tel { get; set; }

        [StringLength(10)]
        public string taxacc_tel1 { get; set; }

        [StringLength(20)]
        public string taxacc_fax { get; set; }
    }
}
