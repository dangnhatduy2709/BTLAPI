namespace HoaQua_Nguoidung.Model
{
    public class ProductFilterRequestModel
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public int? ProductName { get; set; }

        public int? ProductId { get; set; }

        public string? TenLoai { get; set; }

        public decimal? FromPrice { get; set; }

        public decimal? ToPrice { get; set; }
    }
}
