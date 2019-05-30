using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBtbrt.Models.ViewModel
{
	public class APCustVM
	{
		public apcust apcusts { get; set; }
		public custz custzs { get; set; }

		public string psc_name { get; set; }
		public string tsc_name { get; set; }
	}
}