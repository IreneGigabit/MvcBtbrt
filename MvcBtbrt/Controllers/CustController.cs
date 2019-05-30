using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBtbrt.Models;
using MvcBtbrt.Models.Repository;

namespace MvcBtbrt.Controllers
{
    public class CustController : Controller
    {
        //
        // GET: /Cust/
		
		BtbrtContext db = new BtbrtContext();

		public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Index(string searchName) {
			//var vcust = db.apcust.Where(a => a.ap_cname1.Contains(searchName));
			var apcust = new ApCustRepository();
			var vcust = apcust.GetApCustByName(searchName);

			return View(vcust);
		}

    }
}
