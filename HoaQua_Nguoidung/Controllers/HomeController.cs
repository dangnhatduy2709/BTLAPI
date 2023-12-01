using HoaQua_Nguoidung.Model;
using Microsoft.AspNetCore.Mvc;
using BLL;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Models;


namespace HoaQua_Nguoidung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase

    {
        private readonly IMatHangBusiness _MatHangBusiness;
        private readonly ILoaiHangBusiness _LoaiHangBusiness;
        private readonly INhaCCBusiness _NhaCCBusiness;
        public KhachHangController(IMatHangBusiness MatHangBusiness, ILoaiHangBusiness LoaiHangBusiness, INhaCCBusiness NhaCCBusiness)
        {
            _MatHangBusiness = MatHangBusiness;
            _LoaiHangBusiness = LoaiHangBusiness;
            _NhaCCBusiness = NhaCCBusiness;

        }
        [Route("GetAllProduct")]
        [HttpGet]
        public async Task<List<MatHangModel>> GetAllProduct()
        {

            return await _MatHangBusiness.GetAllProduct();
        }
        [Route("GetNewProduct")]
        [HttpGet]
        public async Task<List<KhachHangModel>> GetNewProduct(int Soluong)
        {
            return await _MatHangBusiness.GetNewProduct(Soluong);
        }
        [Route("get-by-id_LoaiMatHang")]
        [HttpGet]
        public async Task<LoaiHangModel> GetById(int id)
        {
            return await _LoaiHangBusiness.GetById(id);
        }
        [Route("get-all_LoaiMatHang")]
        [HttpGet]
        public async Task<List<LoaiHangModel>> GetAll()
        {
            return await _LoaiHangBusiness.GetAll();
        }
        [Route("GetProductCategory")]
        [HttpGet]
        public async Task<List<MatHangModel>> GetProductCategory(int id)
        {
            return await _MatHangBusiness.GetProductCategory(id);
        }
        [Route("GetProductBanchay")]
        [HttpGet]
        public async Task<List<KhachHangModel>> GetProductBanChay(int sl)
        {
            return await _MatHangBusiness.GetProductBanChay(sl);
        }

        [Route("GetProductOder")]
        [HttpGet]
        public async Task<List<KhachHangModel>> GetProductOder(int sl)
        {


            return await _MatHangBusiness.GetProductOder(sl);
        }
        [Route("GetByIdProduct")]
        [HttpGet]
        public async Task<MatHangModel> GetByIdProduct(int id)
        {

            return await _MatHangBusiness.GetByIdProduct(id);
        }
        [Route("GetAllDonHangBan")]
        [HttpGet]
        public async Task<List<DonHangBanModel>> GetAllDonHangBan()
        {
            return await _MatHangBusiness.GetAllDonHangBan();
        }
        [Route("GetAllNhaCC")]
        [HttpGet]
        public async Task<List<NhaCCModel>> GetAllNhaCC()
        {
            return await _NhaCCBusiness.GetAllNhaCC();
        }
        [Route("SearchMatHang")]
        [HttpPost]
        public ReponseModel Search([FromBody] ProductFilterRequestModel productFilterRequestModel)
        {
            var response = new ReponseModel();
            try
            {
                long total = 0;
                var data = _MatHangBusiness.Search(
                    productFilterRequestModel.PageIndex,  
                    productFilterRequestModel.PageSize,
                    out total,
                    productFilterRequestModel.ProductId,
                    productFilterRequestModel.ProductName,
                    productFilterRequestModel.TenLoai,
                    null,
                    productFilterRequestModel.FromPrice,
                    productFilterRequestModel.ToPrice);
                response.TotalItems = total;
                response.Data = data;
                response.Page = productFilterRequestModel.PageIndex;
                response.PageSize = productFilterRequestModel.PageSize;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return response;
        }
    }
}
