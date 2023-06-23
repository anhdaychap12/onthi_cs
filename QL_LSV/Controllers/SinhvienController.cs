using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QL_LSV.Models;
using Newtonsoft.Json;
using System.Globalization;

namespace QL_LSV.Controllers
{
    public class SinhvienController : Controller
    {
        DataQL_LSVDataContext db = new DataQL_LSVDataContext();
        // GET: Sinhvien
        public ActionResult Index()
        {
            var count_ds = db.tbl_Sinhviens.Count();
            ViewData["count"] = count_ds;
            return View();
        }

        public string GetList(string pageItem)
        {
            int limit = 2;
            int offset = int.Parse(pageItem) * limit - limit;
            var dssv = db.tbl_Sinhviens.Skip(offset).Take(limit).ToList();
            return JsonConvert.SerializeObject(dssv);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public string PostCreate()
        {
            Result_ett<string> rs = new Result_ett<string>();
            try
            {
                string Name = Request["f_Name"];
                string MSSV = Request["f_MSSV"];
                string Address = Request["f_Address"];
                string Birthday = Request["f_Birthday"];
                string Gender = Request["f_Gender"];

                tbl_Sinhvien newSV = new tbl_Sinhvien();
                newSV.sv_mssv = MSSV;
                newSV.sv_name = Name;
                newSV.sv_address = Address;
                newSV.sv_birthday = DateTime.ParseExact(Birthday, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                newSV.sv_gender = Gender;
                db.tbl_Sinhviens.InsertOnSubmit(newSV);
                db.SubmitChanges();
                rs.ErrCode = EnumErrCode.Success;
                rs.Message = "Thêm mới sinh viên thành công";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Fail;
                rs.ErrDetail = ex.Message;
                rs.Message = "Thêm mới sinh viên không thành công";
                return JsonConvert.SerializeObject(rs);
            }
            return JsonConvert.SerializeObject(rs);
        }

        public ActionResult Edit()
        {
            return View();
        }

        public string GetSV(string id)
        {
            var int_id = int.Parse(id);
            var dssv = db.tbl_Sinhviens.Where(o => o.id == int_id).FirstOrDefault();
            return JsonConvert.SerializeObject(dssv);
        }

        public string PostEdit()
        {
            Result_ett<string> rs = new Result_ett<string>();
            try
            {
                string id = Request["f_id"];
                int int_id = int.Parse(id);
                string Name = Request["f_Name"];
                string MSSV = Request["f_MSSV"];
                string Address = Request["f_Address"];
                string Birthday = Request["f_Birthday"];
                string Gender = Request["f_Gender"];

                tbl_Sinhvien newSV = db.tbl_Sinhviens.Where(o => o.id == int_id).FirstOrDefault();
                newSV.sv_mssv = MSSV;
                newSV.sv_name = Name;
                newSV.sv_address = Address;
                newSV.sv_birthday = DateTime.ParseExact(Birthday, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                newSV.sv_gender = Gender;
                db.SubmitChanges();
                rs.ErrCode = EnumErrCode.Success;
                rs.Message = "Cập nhật thành công";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Fail;
                rs.ErrDetail = ex.Message;
                rs.Message = "Cập nhật không thành công";
                return JsonConvert.SerializeObject(rs);
            }
            return JsonConvert.SerializeObject(rs);
        }

    }
}