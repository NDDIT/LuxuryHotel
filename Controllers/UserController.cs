using LuxuryHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuxuryHotel.Controllers
{
    public class UserController : Controller
    {
        dbDataContext db = new dbDataContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(FormCollection collection, CUSTOMER kh)
        {
            //Gan cac gia tri nguoi dung nhap du lieu cho cac bien
            var sUser = collection["User"];
            var sPassword = collection["Password"];
            var sConfirmPassword = collection["ConfirmPassword"];
            var sFullName = collection["FullName"];
            var sEmail = collection["Email"];
            var sPhoneNumber = collection["PhoneNumber"];
            if (String.IsNullOrEmpty(sUser))
            {
                ViewData["err1"] = "Tên đăng nhập không được rỗng";
            }
            else if (String.IsNullOrEmpty(sPassword))
            {
                ViewData["err2"] = "Phải nhập lại mật khẩu";
            }
            else if (String.IsNullOrEmpty(sConfirmPassword))
            {
                ViewData["err3"] = "Phải nhập lại mật khẩu";
            }

            else if (sPassword != sConfirmPassword)
            {
                ViewData["err4"] = "Mật khẩu nhập lại không khớp";
            }
            else if (String.IsNullOrEmpty(sFullName))
            {
                ViewData["err5"] = "Họ Tên không được rỗng";
            }

            else if (String.IsNullOrEmpty(sEmail))
            {
                ViewData["err6"] = "Email không được rổng";
            }

            else if (String.IsNullOrEmpty(sPhoneNumber))
            {
                ViewData["err7"] = "Số điện thoại không được rỗng";
            }

            else if (db.CUSTOMERs.SingleOrDefault(n => n.User == sUser) != null)
            {
                ViewBag.ThongBao = "Tên đăng nhập đã tồn tại";
            }

            else if (db.CUSTOMERs.SingleOrDefault(n => n.Email == sEmail) != null)
            {
                ViewBag.ThongBao = "Email đã được sử dụng";
            }
            else
            {
                kh.User = sUser;
                kh.Password = sPassword;
                kh.FullName = sFullName;
                kh.Email = sEmail;
                kh.Email = sEmail;
                kh.PhoneNumber = sPhoneNumber; 
                db.CUSTOMERs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return RedirectToAction("DangNhap");
            }
            return this.DangKy();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var sUser = collection["User"];
            var sPassword = collection["Password"];
            if (String.IsNullOrEmpty(sUser))
            {
                ViewData["Err1"] = "Bạn chưa nhập tên đăng nhập";
            }

            else if (String.IsNullOrEmpty(sPassword))
            {
                ViewData["Err2"] = "Phải nhập mật khẩu";
            }
            else
            {
                CUSTOMER kh = db.CUSTOMERs.SingleOrDefault(n => n.User == sUser && n.Password == sPassword);
                if (kh != null)
                {
                    ViewBag.ThongBao = "Chúc mừng đăng nhập nhành công";
                    Session["User"] = kh;
                    

                }
                else
                {
                    Session["User"] = kh;
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
                }

            }
            return View();
        }

    }
}