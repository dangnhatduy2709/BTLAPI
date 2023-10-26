using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class KhachHangModel
    {
        public long KhachHangID { get; set; }
        public int HoTenKH { get; set; }
        public int DiaChiKH { get; set; }
        public int EmailKH { get; set; }
        public string SdtKH { get; set; }
    }
}