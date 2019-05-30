namespace MvcBtbrt.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class SysctrlContext : DbContext
	{
		public SysctrlContext()
			: base("name=SysctrlContext") {
		}

		public virtual DbSet<country> country { get; set; }
		public virtual DbSet<scode> scode { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<country>()
				.Property(e => e.coun_code)
				.IsUnicode(false);

			modelBuilder.Entity<country>()
				.Property(e => e.coun_e)
				.IsUnicode(false);

			modelBuilder.Entity<country>()
				.Property(e => e.coun_c)
				.IsUnicode(false);

			modelBuilder.Entity<country>()
				.Property(e => e.cl)
				.IsUnicode(false);

			modelBuilder.Entity<country>()
				.Property(e => e.ccode)
				.IsUnicode(false);

			modelBuilder.Entity<country>()
				.Property(e => e.markc)
				.IsUnicode(false);

			modelBuilder.Entity<country>()
				.Property(e => e.buss_c)
				.IsUnicode(false);

			modelBuilder.Entity<country>()
				.Property(e => e.tran_scode)
				.IsUnicode(false);

			modelBuilder.Entity<country>()
				.Property(e => e.markb)
				.IsUnicode(false);

			modelBuilder.Entity<country>()
				.Property(e => e.markf)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.scode1)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.sys_pwd)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.sc_name)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.se_name)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.UserType)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.lev)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.Email)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.sscode)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.ReMark)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.comp)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.mark1)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.mark2)
				.IsUnicode(false);

			modelBuilder.Entity<scode>()
				.Property(e => e.tran_scode)
				.IsUnicode(false);
		}
	}
}
