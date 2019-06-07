using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using MvcBtbrt.Models;

namespace MvcBtbrt.Controllers
{
    public class HomeController : Controller
    {
		//
		// GET: /Home/
		//protected string connStr = ConfigurationManager.ConnectionStrings["BtbrtHome"].ToString();
        protected string connStr = ConfigurationManager.ConnectionStrings["BtbrtMom"].ToString();

		public ActionResult Index()
        {
			using (var cnn = new SqlConnection(connStr)) {
				string sql = @"SELECT * FROM dmt1";
				var data = cnn.QueryFirst<dmt1>(sql);
				return View(data);
			}
        }

		//public void Update([Bind(Exclude = "seq1")]dmt1 model) {
		public ActionResult Update(dmt1 model) {
				dmt1 org = new dmt1()
				{
					seq = model.seq,
					appl_name = model.appl_name,
					term1 = model.term1,
					term2 = model.term2,
					apply_no = model.apply_no,
					issue_no = model.issue_no,
				};

			
			using (var cnn = new SqlConnection(connStr)) {
				/*
				string sql = @"update dmt1 set 
seq=@seq,seq1=@seq1,appl_name=@appl_name,term1=@term1,term2=@term2,apply_no=@apply_no,issue_no=@issue_no";
				cnn.Execute(sql, model);
				*/

				var sql = @"update dmt1 set 
						seq= CASE WHEN @seq IS NULL THEN seq ELSE @seq END
						,seq1=CASE WHEN @seq1 IS NULL THEN seq1 ELSE @seq1 END
						,appl_name=CASE WHEN @appl_name IS NULL THEN appl_name ELSE @appl_name END
						,term1=CASE WHEN @term1 IS NULL THEN term1 ELSE @term1 END
						,term2=CASE WHEN @term2 IS NULL THEN term2 ELSE @term2 END
						,apply_no=CASE WHEN @apply_no IS NULL THEN apply_no ELSE @apply_no END
						,issue_no=CASE WHEN @issue_no IS NULL THEN issue_no ELSE @issue_no END";
				cnn.Execute(sql, org);
				
				//var resultado = cnn.Execute(sql, model);
			}


			return RedirectToAction("Index");
		}
    }
}
