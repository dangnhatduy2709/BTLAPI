using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DonHangBanModel
    {
        public int DonHangBanID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayBan { get; set; }
        public float TrietKhauBan { get; set; }

    }
}
