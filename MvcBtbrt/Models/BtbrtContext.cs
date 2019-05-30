namespace MvcBtbrt.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class BtbrtContext : DbContext
	{
		public BtbrtContext()
			: base("name=BtbrtContext") {
		}

		public virtual DbSet<apcust> apcust { get; set; }
		public virtual DbSet<apcust_attach> apcust_attach { get; set; }
		public virtual DbSet<apcust_attach_ref> apcust_attach_ref { get; set; }
		public virtual DbSet<Cust_code> Cust_code { get; set; }
		public virtual DbSet<custz> custz { get; set; }
		public virtual DbSet<custz_att> custz_att { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<apcust>()
				.Property(e => e.apcust_no)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.apclass)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.cust_area)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_cname1)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_cname2)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_ename1)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_ename2)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_crep)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_erep)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_country)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_zip)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_addr1)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_addr2)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_eaddr1)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_eaddr2)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_eaddr3)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_eaddr4)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.apatt_zip)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.apatt_addr1)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.apatt_addr2)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.apatt_tel0)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.apatt_tel)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.apatt_tel1)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.apatt_fax)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_code)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.tran_scode)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.dmp_seq)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.exp_seq)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.dmt_seq)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ext_seq)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.mark)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_title)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_fcname)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_lcname)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_fename)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.ap_lename)
				.IsUnicode(false);

			modelBuilder.Entity<apcust>()
				.Property(e => e.apatt_email)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.apattach_sqlno)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.cust_area)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.source)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.in_scode)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.in_prgid)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.contract_no)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.sign_flag)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.company)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.dept)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.country)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.sign_scode)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.agt_no)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.agent_no)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.agent_no1)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.attach_path)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.doc_type)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.attach_desc)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.attach_name)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.source_name)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.attach_size)
				.HasPrecision(9, 0);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.attach_flag)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.stop_remark)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.main_dept)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.main_seq1)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.mcontract_no)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.mremark)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.remark)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.mark)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.tran_scode)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach>()
				.Property(e => e.tran_prgid)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach_ref>()
				.Property(e => e.apattach_sqlno)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach_ref>()
				.Property(e => e.mark)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach_ref>()
				.Property(e => e.tran_scode)
				.IsUnicode(false);

			modelBuilder.Entity<apcust_attach_ref>()
				.Property(e => e.tran_prgid)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.Code_type)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.Cust_code1)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.Code_name)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.SortFld)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.form_name)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.Ref_code)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.Dept)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.Remark)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.Mark)
				.IsUnicode(false);

			modelBuilder.Entity<Cust_code>()
				.Property(e => e.mark1)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.cust_area)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.id_no)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.www)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.email)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.con_code)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.acc_zip)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.acc_addr1)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.acc_addr2)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.acc_tel0)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.acc_tel)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.acc_tel1)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.acc_fax)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.rmark_code)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.ref_no)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.mag)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pscode)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.plevel)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pdis_type)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.ppay_type)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tscode)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tlevel)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tdis_type)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tpay_type)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.in_scode)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tran_code)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.ttran_scode)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.ptran_scode)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.cust_remark)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.mark)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tran_remark)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tran_ctrl)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pacc_email)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_email)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_zip)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_addr1)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_addr2)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_tel0)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_tel)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_tel1)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_fax)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.acc_remark)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pspay_flag)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tspay_flag)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pacc_chkcode)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_chkcode)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pacc_attention)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pacc_title)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_attention)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tacc_title)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tax_zip)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tax_addr1)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tax_addr2)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tax_tel0)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tax_tel)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tax_tel1)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tax_fax)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.payout_mark)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pspay_source)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pspay_seq)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.pspay_refno)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tspay_source)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tspay_seq)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tspay_refno)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tax_attention)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.tax_email)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.taxacc_attention)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.taxacc_email)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.taxacc_zip)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.taxacc_addr1)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.taxacc_addr2)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.taxacc_tel0)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.taxacc_tel)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.taxacc_tel1)
				.IsUnicode(false);

			modelBuilder.Entity<custz>()
				.Property(e => e.taxacc_fax)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.cust_area)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.dept)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.attention)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_company)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_title)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_dept)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_tel0)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_tel)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_tel1)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_mobile)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_fax)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_zip)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_addr1)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_addr2)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_email)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_mag)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.att_code)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.ttran_scode)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.ptran_scode)
				.IsUnicode(false);

			modelBuilder.Entity<custz_att>()
				.Property(e => e.mark)
				.IsUnicode(false);
		}
	}
}
