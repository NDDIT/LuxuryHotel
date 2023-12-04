using LuxuryHotel.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuxuryHotel.Areas.Reception.Controllers
{
    public class UtilitiesController : Controller
    {
        // GET: Reception/Utilities
        private dbDataContext _db = new dbDataContext();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetUtilities()
        {
            try
            {
                var utilities = _db.Utilities
                    .Select(r => new
                    {
                        UtilitiesID = r.UtilitiesID,
                        UtilitiesName = r.UtilitiesName,
                        UtilitiesPicture = r.UtilitiesPicture,
                    })
                    .ToList();

                return Json(new { code = 200, utilities = utilities, msg = "Lấy thông tin dich vu thành công" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Lấy thông tin dich vu thất bại: " + e.Message }, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public JsonResult CreateUtilities(int UtilitiesID, string UtilitiesName, string UtilitiesPicture)
        {
            try
            {
                if (ModelState.IsValid)
                {
              
                    Utility utilities = new Utility
                    {
                        // Thiết lập giá trị từ tham số

                        UtilitiesID = UtilitiesID,
                        UtilitiesName = UtilitiesName,
                        UtilitiesPicture = UtilitiesPicture,
                    };

                    // Thêm loại phòng mới vào database
                    _db.Utilities.InsertOnSubmit(utilities);
                    _db.SubmitChanges();

                    return Json(new { code = 200, msg = "Room Type created successfully." });
                }

                return Json(new { code = 400, msg = "Invalid data. Please check your inputs." });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
        }


        [HttpPost]
        public JsonResult Edit(int UtilitiesID, string UtilitiesName, string UtilitiesPicture)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existingUtilities = _db.Utilities.SingleOrDefault(r => r.UtilitiesID == UtilitiesID);

                    if (existingUtilities != null)
                    {
                        existingUtilities.UtilitiesName = UtilitiesName;

                        // Chuyển đổi giá trị từ chuỗi sang kiểu int
                        existingUtilities.UtilitiesName = UtilitiesName;
                        existingUtilities.UtilitiesPicture = UtilitiesPicture;
                        _db.SubmitChanges();
                        return Json(new { code = 200, msg = "Utilities updated successfully." });
                    }
                }

                return Json(new { code = 400, msg = "Invalid data. Please check your inputs." });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
        }


        [HttpGet]
        public JsonResult GetUtilitiesDetails(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return Json(new { code = 400, msg = "Giá trị ID không hợp lệ" }, JsonRequestBehavior.AllowGet);
                }

                var utilities = _db.Utilities
                    .Where(r => r.UtilitiesID == id)
                    .Select(r => new
                    {
                        UtilitiesID = r.UtilitiesID,
                        UtilitiesName = r.UtilitiesName,
                        UtilitiesPicture = r.UtilitiesPicture,

                    })
                    .SingleOrDefault();

                if (utilities != null)
                {
                    return Json(new { code = 200, utilities = utilities, msg = "Lấy thông tin dich vu thành công" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { code = 404, msg = "Không tìm thấy thông tin dich vu" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in GetUtilitiesDetails: " + e.Message);
                return Json(new { code = 500, msg = "Lấy thông tin dich vu thất bại: " + e.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public JsonResult CheckAndDeleteUtilities(int UtilitiesID)
        {
            try
            {
                var utilities = _db.Utilities.SingleOrDefault(r => r.UtilitiesID == UtilitiesID);

                if (utilities != null)
                {
                    _db.Utilities.DeleteOnSubmit(utilities);
                    _db.SubmitChanges();

                    return Json(new { code = 200, msg = "utilities deleted successfully." });
                }
                else
                {
                    return Json(new { code = 404, msg = "Không tìm thấy dich vu để xóa." });
                }
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Đã xảy ra lỗi khi xóa utilities: " + ex.Message });
            }
        }
    }
}