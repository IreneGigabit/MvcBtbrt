using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using MvcBtbrt.Models.ViewModel;

namespace MvcBtbrt.Models.Repository
{
	public class ApCustRepository
	{
		private BtbrtContext db = new BtbrtContext();
		private SysctrlContext sysdb = new SysctrlContext();

		public IQueryable<apcust> GetAllApcust(int Count)
		//抓出所有Apcust資料，參數可決定筆數，如果為0就傳回全部
		{
			var c = from d in db.apcust select d;
			return (Count > 0 ? c.Take(Count) : c);
		}

		public IEnumerable<APCustVM> GetApCustByName(string ap_cname1)   //抓like ap_cname1符合的資料
			{
			var result = (from a in db.apcust
						  from c in db.custz
						  where a.cust_area == a.cust_area && a.cust_seq == c.cust_seq && a.ap_cname1.Contains(ap_cname1)
						  select new { apcusts = a, custzs = c })
						 .ToList()
						.Select(c => new APCustVM
						{
							apcusts = c.apcusts,
							custzs = c.custzs,
							psc_name = sysdb.scode.Where(a => a.scode1 == c.custzs.pscode).Select(s=>  s.sc_name ).FirstOrDefault(),
							tsc_name = sysdb.scode.Where(a => a.scode1 == c.custzs.tscode).Select(s=>  s.sc_name ).FirstOrDefault()
						});
			return result;
		}
		/*
		 * public IEnumerable<apcust> GetApCustByName(string ap_cname1)   //抓like ap_cname1符合的資料
		{
			//var c = (from d in db.apcust where d.ap_cname1.Contains(ap_cname1) select d);
			//var c = db.apcust.Where(a => a.ap_cname1.Contains(ap_cname1));
			
			string sql = @"SELECT *
                             FROM apcust 
                            WHERE ap_cname1 like @ap_cname1";
			using (var cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["BtbrtDapper"].ToString())) {
				var data = cnn.Query<apcust>(sql, new { ap_cname1 = "%"+ap_cname1+"%" });
				return data;
			}

			using (DBHelper conn = new DBHelper(ConfigurationManager.ConnectionStrings["BtbrtDapper1"].ToString())) {
				DataTable dt = new DataTable();
				conn.DataTable("select * from apcust where ap_cname1 like '%英業%'", dt);
				apcust rst1 = new apcust() { ap_cname1 = dt.Rows[0]["ap_cname1"].ToString(), ap_crep = dt.Rows[0]["ap_crep"].ToString() };
				List<apcust> rst = new List<apcust>();
				rst.Add(rst1);
				return rst;
			}
		}
		*/
		public apcust GetApCustBySqlno(int sqlno)   //符合sqlno的資料
		{
			var c = (from d in db.apcust where d.apsqlno.Equals(sqlno) select d).FirstOrDefault();
			return c;
		}


		public void InsertApCust(apcust apcust)   //新增一筆ApCust資料
		{
			db.apcust.Add(apcust);
			db.SaveChanges();
		}

		public bool DeleteApCust(int delApsqlno)   //刪除一筆資料
		{
			/*
			//1.創建要刪除的對象
			apcust apcustDel = new apcust() { apsqlno = delApsqlno };
			//2.將對象添加到EF管理容器
			db.apcust.Attach(apcustDel);
			//3.將對象包裝類的狀態標識為刪除狀態
			db.apcust.Remove(apcustDel);
			//4.更新到數據庫
			db.SaveChanges();
			*/

			var p = (from d in db.apcust where d.apsqlno.Equals(delApsqlno) select d).FirstOrDefault();
			if (p == null) {
				return false;
			} else {
				db.apcust.Remove(p);
				db.SaveChanges();
				return true;
			}
		}
	}
}