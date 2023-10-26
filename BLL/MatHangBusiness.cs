using BLL.Interfaces;
using DAL;
using DAL.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public partial class MatHangBusiness : IMatHangBusiness
    {
        private readonly IMatHangReponsitory _res;
        public MatHangBusiness(IMatHangReponsitory res)
        {
            _res = res;
        }

        public async Task<bool> Create(MatHangModel model)
        {
            return await _res.Create(model);
        }

        public async Task<bool> Delete(int id)
        {
            return await _res.Delete(id);
        }

        public async Task<bool> Update(MatHangModel model)
        {
            return await _res.Update(model);
        }
        public async Task<List<MatHangModel>> GetAllProduct()
        {
            return await _res.GetAllProduct();
        }

        public async Task<List<KhachHangModel>> GetNewProduct(int Soluong)
        {
            return await _res.GetNewProduct(Soluong);
        }
        public async Task<List<MatHangModel>> GetProductCategory(int id)
        {
            return await _res.GetProductCategory(id);
        }
        public async Task<List<KhachHangModel>> GetProductBanChay(int sl)
        {
            return await _res.GetProductBanChay(sl);
        }
        public async Task<List<KhachHangModel>> GetProductOder(int sl)
        {
            return await _res.GetProductOder(sl);
        }
        public async Task<MatHangModel> GetByIdProduct(int id)
        {
            return await _res.GetByIdProduct(id);
        }
        public async Task<List<DonHangBanModel>> GetAllDonHangBan()
        {
            return await _res.GetAllDonHangBan();
        }
        public List<MatHangModel> Search(int pageIndex, int pageSize, out long total, int? LoaiHangID, int? MatHangID, string? TenHang, string option, decimal? FromPrice, decimal? ToPrice)
        {
            return _res.Search(pageIndex, pageSize,out total, LoaiHangID, MatHangID, TenHang, option, FromPrice, ToPrice);
        }


    }
}
