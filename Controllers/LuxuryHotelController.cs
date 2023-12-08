using LuxuryHotel.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PagedList.Mvc;
using System.Drawing;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Data.Linq;
using System.Web.UI;

namespace LuxuryHotel.Controllers
{
    public class LuxuryHotelController : Controller
    {
        dbDataContext db = new dbDataContext();
        // GET: LuxuryHotel
        public ActionResult Index()
        {

            var areas = from kv in db.ROOMs select kv;

            return View(areas);
        }
        public ActionResult SearchPhong(int? size, int? page, string sortProperty, string sortOrder, string strSearch, int typeRoomID = 0)
        {
            List<SelectListItem> items = new List<SelectListItem>
    {
        new SelectListItem { Text = "3", Value = "3" },
        new SelectListItem { Text = "5", Value = "5" },
        new SelectListItem { Text = "10", Value = "10" },
        new SelectListItem { Text = "20", Value = "20" },
        new SelectListItem { Text = "25", Value = "25" },
        new SelectListItem { Text = "50", Value = "50" }
    };

            ViewBag.size = items;
            ViewBag.currentSize = size;
            ViewBag.Search = strSearch;

            int iSize = (size ?? 3);
            int iPageNumber = (page ?? 1);

            var kq = from s in db.ROOMs select s;

            if (!string.IsNullOrEmpty(strSearch))
            {
                kq = kq.Where(s => s.RoomName.Contains(strSearch));
            }

            if (!string.IsNullOrEmpty(sortProperty))
            {
                if (sortOrder == "desc")
                    kq = kq.OrderBy(sortProperty + " desc");
                else
                    kq = kq.OrderBy(sortProperty);
            }

            if (typeRoomID != 0)
            {
                kq = kq.Where(s => s.ROOMTYPE.RoomTypeID == typeRoomID);

            }

            ViewBag.typeRoomID = new SelectList(db.ROOMTYPEs, "RoomTypeID", "TypeName");

            ViewBag.SortOrder = sortOrder;
            ViewBag.SortProperty = sortProperty;

            return View(kq.ToPagedList(iPageNumber, iSize));
        }
        public ActionResult TimKiem(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                // Nếu từ khóa tìm kiếm là null hoặc chuỗi rỗng, bạn có thể xử lý nó ở đây (ví dụ: hiển thị thông báo lỗi).
                // Sau đó trả về trang tìm kiếm hoặc trang chính tùy theo yêu cầu của bạn.
                return View("Index");
            }

            var query = from kv in db.ROOMs
                        where kv.RoomName.Contains(s) ||
                              kv.RoomStatus.Contains(s) ||
                             kv.RoomTypeID.ToString().Contains(s) ||
                              kv.ROOMTYPE.TypeName.Contains(s) ||
                              kv.Area.Contains(s)
                        select kv;

            var kvs = query.ToList(); // Chuyển kết quả thành danh sách

            // Trả về view TimKiem và truyền danh sách kết quả tìm kiếm
            return View("TimKiem", kvs);
        }

        public ActionResult ViewSearch(string searchString, int typeRoomID = 0)
        {
            var kq = db.ROOMs.Include(b => b.ROOMTYPE);

            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                kq = kq.Where(b => b.RoomStatus.ToLower().Contains(searchString) ||
                                  b.RoomName.ToLower().Contains(searchString) ||
                                  b.ROOMTYPE.TypeName.ToLower().Contains(searchString));
            }

            if (typeRoomID != 0)
            {
                kq = kq.Where(b => b.ROOMTYPE.RoomTypeID == typeRoomID);
            }

            ViewBag.RoomTypeID = new SelectList(db.ROOMTYPEs, "RoomTypeID", "TypeName");

            return View(kq.ToList());
        }

        public ActionResult ChiTietPhong(int iRoomID)
        {
            var room = db.ROOMs.FirstOrDefault(s => s.RoomID == iRoomID);

            if (room != null)
            {
                return View(room);
            }
            else
            {
                return HttpNotFound("Phòng không tồn tại.");
            }
        }
        private List<Image> LayPhongMoi(int count)
        {
            return data.Imagees.OrderByDescending(a => a.ImageID).Take(count).ToList();
        }

    }
}