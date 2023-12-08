using System;
using System.IO;
using System.Linq;

namespace LuxuryHotel.Models
{
    public class BookRoom
    {
        private dbDataContext db = new dbDataContext();

        public int iRoomID { get; set; }
        public string sRoomName { get; set; }
        public string sArea { get; set; }

        public string sRoomType { get; set; }
        public double dPriceByDay { get; set; }
        public double dPricePerHour { get; set; }
        public double dOverNightPrice { get; set; }
        public double dPriceFirstHour { get; set; }
        public double dPriceOverTime { get; set; }

        public int iSoLuong { get; set; }

        public double dTotalByDay { get { return iSoLuong * dPriceByDay; } }
        public double dTotalByHour { get { return (iSoLuong - 1) * dPricePerHour + dPriceFirstHour + CalculateOvertimePenalty(); } }
        public double dTotalOvernight { get { return (dCheckOut - dCheckIn).TotalDays > 1 ? (dCheckOut - dCheckIn).TotalDays * dOverNightPrice : 0; } }
        public double dTotalOvertime { get { return (dCheckOut - dCheckIn).TotalHours > 8 ? ((dCheckOut - dCheckIn).TotalHours - 8) * dPriceOverTime : 0; } }
        private double CalculateOvertimePenalty()
        {
            // Thực hiện logic tính phạt quá giờ ở đây
            // Ví dụ: (số giờ quá giờ) * giá quá giờ
            return Math.Max((dCheckOut - dCheckIn).TotalHours - iSoLuong, 0) * dPriceOverTime;
        }
        public DateTime dCheckIn { get; set; }
        public DateTime dCheckOut { get; set; }

        public BookRoom(int ms)
        {
            iRoomID = ms;
            ROOM s = db.ROOMs.Single(n => n.RoomID == iRoomID);

            // Assuming there is only one image associated with the room

            // Assign properties based on the selected room
            sRoomName = s.RoomName;
            sArea = s.Area;

            sRoomType = s.ROOMTYPE.TypeName;
            dPriceByDay = (double)s.ROOMTYPE.PriceByDay;
            dPricePerHour = (double)s.ROOMTYPE.PricePerHour;
            dOverNightPrice = (double)s.ROOMTYPE.OverNightPrice;
            dPriceOverTime = (double)s.ROOMTYPE.PriceOverTime;
            dPriceFirstHour = (double)s.ROOMTYPE.PriceFirstHour;

        }
    }
}
