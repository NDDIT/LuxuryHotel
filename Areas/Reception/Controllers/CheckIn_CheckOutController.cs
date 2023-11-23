using LuxuryHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuxuryHotel.Areas.Reception.Controllers
{
    public class CheckIn_CheckOutController : Controller
    {
        private dbDataContext db = new dbDataContext();
        // GET: Reception/CheckIn_CheckOut
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetRoomAvaiable(string area)
        {
            try
            {
                var rooms = db.ROOMs.Where(r => (r.Area == area)&& (r.RoomStatus == "Available")).Select(r => new
                {
                    RoomID = r.RoomID,
                    RoomName = r.RoomName,
                    RoomStatus = r.RoomStatus,
                    RoomTypeID = r.RoomTypeID,
                    Area = r.Area
                }).ToList();

                return Json(new { code = 200, rooms = rooms, area= area, msg = "Lấy danh sách phòng thành công" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, msg = "Lấy danh sách phòng thất bại: " + e.Message }, JsonRequestBehavior.AllowGet);
            }
        }




    }
}