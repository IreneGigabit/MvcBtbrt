namespace MvcBtbrt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class apcust_attach_ref
    {
        [Key]
        public int apattach_ref_sqlno { get; set; }

        [Required]
        [StringLength(10)]
        public string apattach_sqlno { get; set; }

        public int apsqlno { get; set; }

        [StringLength(1)]
        public string mark { get; set; }

        public DateTime? tran_date { get; set; }

        [StringLength(5)]
        public string tran_scode { get; set; }

        [StringLength(10)]
        public string tran_prgid { get; set; }
    }
}
