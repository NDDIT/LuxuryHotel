using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuxuryHotel.Controllers
{
    public class LuxuryHotelController : Controller
    {
        // GET: LuxuryHotel
        public ActionResult Index()
        {
            return View();
        }
    }
}