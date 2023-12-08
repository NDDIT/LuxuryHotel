using LuxuryHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace LuxuryHotel.Controllers
{
    public class BookRoomController : Controller
    {
        // GET: BookingRoom
        dbDataContext db = new dbDataContext();
        public List<BookRoom> DatPhong()
        {
            List<BookRoom> lstBooking = Session["BookRoom"] as List<BookRoom>;
            if (lstBooking == null)
            {
                lstBooking = new List<BookRoom>();
                Session["BookRoom"] = lstBooking;
            }
            return lstBooking;
        }
        public ActionResult Index()
        {

            return View();
        }


        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<BookRoom> lstBooking = Session["BookRoom"] as List<BookRoom>;
            if (lstBooking != null)
            {
                iTongSoLuong = lstBooking.Sum(n => n.iSoLuong);
            }
            return iTongSoLuong;
        }

        public ActionResult UpdateRoom(int iRoomID, FormCollection f)
        {
            List<BookRoom> lstBooking = DatPhong();
            BookRoom room = lstBooking.SingleOrDefault(n => n.iRoomID == iRoomID);

            if (room != null)
            {
                room.iSoLuong = int.Parse(f["txtSoLuong"].ToString());

            }


            return RedirectToAction("BookRoom");
        }


        public ActionResult BookRoom()
        {
            List<BookRoom> lstBooking = DatPhong();
            if (lstBooking.Count == 0)
            {
                return RedirectToAction("Index", "LuxuryHotel");
            }
            ViewBag.TongSoLuong = TongSoLuong();

            ViewBag.TongTien = TongTien();
            return View(lstBooking);
        }
        private double TongTien()
        {
            double dTongTienByDay = 0;
            double dTongTienByHour = 0;
            double dTongTienOverNight = 0;

            List<BookRoom> lstBooking = Session["BookRoom"] as List<BookRoom>;
            if (lstBooking != null)
            {
                // Tính tổng của từng giá trị riêng lẻ
                dTongTienByDay = lstBooking.Sum(n => n.dTotalByDay);
                dTongTienByHour = lstBooking.Sum(n => n.dTotalByHour);
                dTongTienOverNight = lstBooking.Sum(n => n.dPriceOverTime);
            }
            return dTongTienByDay + dTongTienByHour + dTongTienOverNight;
        }


        public ActionResult BookRoomPartial()
        {
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return PartialView();
        }
        public ActionResult AddRoom(int ms, string url)
        {
            List<BookRoom> lstBooking = DatPhong();
            BookRoom sp = lstBooking.Find(n => n.iRoomID == ms);
            if (sp == null)
            {
                sp = new BookRoom(ms);
                lstBooking.Add(sp);
            }
            else
            {
                sp.iSoLuong++;
            }
            return Redirect(url);
        }
        public ActionResult DeleteRoom(int iRoomID)
        {
            List<BookRoom> lstBooking = DatPhong();
            BookRoom sp = lstBooking.FirstOrDefault(n => n.iRoomID == iRoomID);
            if (sp != null)
            {
                lstBooking.RemoveAll(n => n.iRoomID == iRoomID);
                if (lstBooking.Count == 0)
                {
                    return RedirectToAction("Index", "LuxxuryHotel");
                }
            }
            return RedirectToAction("BookRoom");

        }
        public ActionResult DeleteBooking()
        {
            List<BookRoom> lstBooking = DatPhong();
            lstBooking.Clear();
            return RedirectToAction("Index", "LuxxuryHotel");
        }
        [HttpGet]
        public ActionResult BookingRoom()
        {
            if (Session["User"] == null || Session["User"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "User");
            }
            if (Session["BookRoom"] == null)
            {
                return RedirectToAction("Index", "LuxuryHotel");
            }
            List<BookRoom> lstBooking = DatPhong();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return View(lstBooking);
        }
        [HttpPost]
        public ActionResult BookingRoom(FormCollection f)
        {
            BOOKING ddh = new BOOKING();
            CUSTOMER kh = (CUSTOMER)Session["User"];
            List<BookRoom> lstBooking = DatPhong();
            ddh.CustomerID = kh.CustomerID;
            var CheckInDate = String.Format("{0:MM/dd/yyyy}", f["CheckInDate"]);
            ddh.CheckInDate = DateTime.Parse(CheckInDate);
            var CheckOutDate = String.Format("{0:MM/dd/yyyy}", f["CheckOutDate"]);
            ddh.CheckOutDate = DateTime.Parse(CheckOutDate);
            ddh.BookingDate = DateTime.Now;
            db.BOOKINGs.InsertOnSubmit(ddh);
            db.SubmitChanges();
            // Lấy thông tin email khách hàng từ session
            string emailKhachHang = ((CUSTOMER)Session["User"]).Email;
            // lấy thôn gtin giỏ hàng từ lstGioHang và tạo nội dung email
            StringBuilder sp = new StringBuilder();
            sp.AppendLine("<h2>Đơn đặt phòng của bạn:</h2>");
            sp.AppendLine("<table style=\"border-collapse: collapse;\">");
            // sp.AppendLine("<tr><th style=\"border: 1px solid black;\">Tên Sách</th><th style=\"border: 1px solid black;\">Số lượng</th><th style=\"border: 1px solid black;\">Đơn Giá</th><th style=\"border: 1px solid black;\">Thành Tiền</th></tr>");
            sp.AppendLine("<tr><th style=\"border: 1px solid black;\">Room Name</th><th style=\"border: 3px solid black;\">Number of Room</th><th style=\"border: 3px solid black;\">Over Night Price</th><th style=\"border: 3px solid black;\">Total of Money</th></tr>");
            foreach (var item in lstBooking)
            {
                sp.AppendLine("<tr>");
                sp.AppendLine($"<td style=\"border: 1px solid black;\">{item.sRoomName}</td>");
                sp.AppendLine($"<td style=\"border: 1px solid black;\">{item.iSoLuong}</td>");
                sp.AppendLine($"<td style=\"border: 1px solid black;\">{item.dOverNightPrice}</td>");
                sp.AppendLine($"<td style=\"border: 1px solid black;\">{ViewBag.TongTien}</td>");
                sp.AppendLine("</tr>");
            }
            sp.AppendLine("</table>");
            sp.AppendLine("<p>Cảm ơn bạn đã đặt hàng! Đơn hàng của bạn đã được nhận và đang được xử lý.</p>");
            // Gửi email thông báo
            string subject = "Đặt phòng thành công";
            string body = sp.ToString();
            string fromEmail = "2124801030213@student.tdmu.edu.vn"; // Địa chỉ email gửi đi
            string toEmail = emailKhachHang; // Địa chỉ email khách hàng

            MailMessage mail = new MailMessage(fromEmail, toEmail, subject, body);
            mail.IsBodyHtml = true; // Cho phép sử dụng HTML trong nội dung email
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587); // Thay thế bằng thông tin SMTP server của bạn
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("2124801030213@student.tdmu.edu.vn", "cukgumscoujzwsvf"); // Thay thế bằng thông tin đăng nhập của bạn

            try
            {
                smtpClient.Send(mail); // Gửi email
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu gửi email không thành công
            }
            db.SubmitChanges();

            Session["BookRoom"] = null;
            return RedirectToAction("XacNhanDonHang", "BookRoom");
        }
        public ActionResult XacNhanDonHang()
        {
            return View();
        }
    }
}