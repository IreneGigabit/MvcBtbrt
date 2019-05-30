namespace MvcBtbrt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apcust")]
    public partial class apcust
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int apsqlno { get; set; }

        [StringLength(10)]
        public string apcust_no { get; set; }

        [StringLength(2)]
        public string apclass { get; set; }

        [StringLength(1)]
        public string cust_area { get; set; }

        public int? cust_seq { get; set; }

        [StringLength(60)]
        public string ap_cname1 { get; set; }

        [StringLength(60)]
        public string ap_cname2 { get; set; }

        [StringLength(100)]
        public string ap_ename1 { get; set; }

        [StringLength(100)]
        public string ap_ename2 { get; set; }

        [StringLength(40)]
        public string ap_crep { get; set; }

        [StringLength(80)]
        public string ap_erep { get; set; }

        [StringLength(6)]
        public string ap_country { get; set; }

        [StringLength(8)]
        public string ap_zip { get; set; }

        [StringLength(120)]
        public string ap_addr1 { get; set; }

        [StringLength(120)]
        public string ap_addr2 { get; set; }

        [StringLength(120)]
        public string ap_eaddr1 { get; set; }

        [StringLength(120)]
        public string ap_eaddr2 { get; set; }

        [StringLength(120)]
        public string ap_eaddr3 { get; set; }

        [StringLength(120)]
        public string ap_eaddr4 { get; set; }

        [StringLength(8)]
        public string apatt_zip { get; set; }

        [StringLength(120)]
        public string apatt_addr1 { get; set; }

        [StringLength(120)]
        public string apatt_addr2 { get; set; }

        [StringLength(4)]
        public string apatt_tel0 { get; set; }

        [StringLength(15)]
        public string apatt_tel { get; set; }

        [StringLength(10)]
        public string apatt_tel1 { get; set; }

        [StringLength(20)]
        public string apatt_fax { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? in_date { get; set; }

        [StringLength(2)]
        public string ap_code { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tran_date { get; set; }

        [StringLength(5)]
        public string tran_scode { get; set; }

        [StringLength(10)]
        public string dmp_seq { get; set; }

        [StringLength(10)]
        public string exp_seq { get; set; }

        [StringLength(10)]
        public string dmt_seq { get; set; }

        [StringLength(10)]
        public string ext_seq { get; set; }

        [StringLength(1)]
        public string mark { get; set; }

        [StringLength(50)]
        public string ap_title { get; set; }

        [StringLength(60)]
        public string ap_fcname { get; set; }

        [StringLength(60)]
        public string ap_lcname { get; set; }

        [StringLength(60)]
        public string ap_fename { get; set; }

        [StringLength(60)]
        public string ap_lename { get; set; }

        [StringLength(100)]
        public string apatt_email { get; set; }
    }
}
