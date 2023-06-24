using Newtonsoft.Json;
using QL_LSV.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QL_LSV.Controllers
{
    public class LopController : Controller
    {
        // GET: Lop
        DataQL_LSVDataContext db = new DataQL_LSVDataContext();
        // GET: Sinhvien
        public ActionResult Index()
        {
            string str_search = Request["str_search"];
            if (string.IsNullOrEmpty(str_search))
            {
                var count_ds = db.tbl_Lops.Count();
                ViewData["count"] = count_ds;
            }
            else
            {
                var count_ds = db.tbl_Lops.Where(o => o.l_name.Contains(str_search)).Count();
                ViewData["count"] = count_ds;
            }

            return View();
        }

        public string GetList(string pageItem, string str_search)
        {

            int limit = 2;
            int offset = int.Parse(pageItem) * limit - limit;
            if (string.IsNullOrEmpty(str_search))
            {
                var dssv = db.tbl_Lops.Skip(offset).Take(limit).ToList();
                return JsonConvert.SerializeObject(dssv);
            }
            else
            {
                var dssv = db.tbl_Lops.Where(o => o.l_name.Contains(str_search)).Skip(offset).Take(limit).ToList();
                return JsonConvert.SerializeObject(dssv);
            }


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
                string tenlop = Request["f_TenLop"];
                string malop = Request["f_MaLop"];

                tbl_Lop newSV = new tbl_Lop();
                newSV.l_malop = malop;
                newSV.l_name = tenlop;               
                db.tbl_Lops.InsertOnSubmit(newSV);
                db.SubmitChanges();
                rs.ErrCode = EnumErrCode.Success;
                rs.Message = "Thêm mới lớp thành công";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Fail;
                rs.ErrDetail = ex.Message;
                rs.Message = "Thêm mới lớp không thành công";
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
            var dssv = db.tbl_Lops.Where(o => o.id == int_id).FirstOrDefault();
            return JsonConvert.SerializeObject(dssv);
        }

        public string PostEdit()
        {
            Result_ett<string> rs = new Result_ett<string>();
            try
            {
                string id = Request["f_id"];
                int int_id = int.Parse(id);
                string tenlop = Request["f_TenLop"];
                string malop = Request["f_MaLop"];
                

                tbl_Lop newSV = db.tbl_Lops.Where(o => o.id == int_id).FirstOrDefault();
                newSV.l_malop = malop;
                newSV.l_name = tenlop;
                
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

        public string Delete(string id)
        {
            Result_ett<string> rs = new Result_ett<string>();
            try
            {
                tbl_Lop delObj = db.tbl_Lops.Where(o => o.id.Equals(id)).FirstOrDefault();
                db.tbl_Lops.DeleteOnSubmit(delObj);
                db.SubmitChanges();
                rs.ErrCode = EnumErrCode.Success;
                rs.Message = "Xóa lớp thành công";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Fail;
                rs.ErrDetail = ex.Message;
                rs.Message = "Xóa lớp không thành công";
                return JsonConvert.SerializeObject(rs);
            }
            return JsonConvert.SerializeObject(rs);
        }


    }
}