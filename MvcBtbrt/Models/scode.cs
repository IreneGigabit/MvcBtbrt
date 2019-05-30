namespace MvcBtbrt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("scode")]
    public partial class scode
    {
        [Key]
        [Column("scode")]
        [StringLength(10)]
        public string scode1 { get; set; }

        [StringLength(50)]
        public string sys_pwd { get; set; }

        [Required]
        [StringLength(50)]
        public string sc_name { get; set; }

        [StringLength(20)]
        public string se_name { get; set; }

        [Required]
        [StringLength(1)]
        public string UserType { get; set; }

        [StringLength(10)]
        public string lev { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string sscode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? beg_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? end_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastVisit { get; set; }

        public int? VisitCount { get; set; }

        [StringLength(255)]
        public string ReMark { get; set; }

        [StringLength(10)]
        public string comp { get; set; }

        [StringLength(10)]
        public string mark1 { get; set; }

        [StringLength(10)]
        public string mark2 { get; set; }

        public DateTime? tran_date { get; set; }

        [StringLength(10)]
        public string tran_scode { get; set; }
    }
}
