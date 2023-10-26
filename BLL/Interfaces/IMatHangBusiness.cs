using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IMatHangBusiness
    {
        Task<bool> Create(MatHangModel model);

        Task<bool> Update(MatHangModel model);
        Task<bool> Delete(int id);
        Task<List<MatHangModel>> GetAllProduct();
        Task<List<KhachHangModel>> GetNewProduct(int Soluong);
        Task<List<MatHangModel>> GetProductCategory(int id);
        Task<List<KhachHangModel>> GetProductBanChay(int sl);
        Task<List<KhachHangModel>> GetProductOder(int sl);
        Task<MatHangModel> GetByIdProduct(int id);
        Task<List<DonHangBanModel>> GetAllDonHangBan();
        List<MatHangModel> Search(int pageIndex, int pageSize,  out long total, int? LoaiHangID, int? MatHangID, string? TenHang,string option, decimal? FromPrice, decimal? ToPrice);
    }
}
