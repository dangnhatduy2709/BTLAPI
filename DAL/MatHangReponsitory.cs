using DAL.Helper;
using DAL.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MatHangRepository : IMatHangReponsitory
    {
        private readonly IDatabaseHelper _dbHelper;
        public MatHangRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public async Task<bool> Create(MatHangModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "MatHang_create",
                "@LoaiHangID ", model.LoaiHangID,
                "@MatHangID", model.MatHangID,
                "@TenHang", model.TenHang,
                "@DVTinh", model.DVTinh,
                "@SLTon", model.SLTon);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> Update(MatHangModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "MatHang_update",
                "@LoaiHangID", model.LoaiHangID,

                "@MatHangID", model.MatHangID,
                "@TenHang", model.TenHang,
                "@DVTinh", model.DVTinh,
                "@SLTon", model.SLTon);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> Delete(int id)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "MatHang_delete", "@LoaiHangID", id);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<MatHangModel>> GetAllProduct()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "MatHang_getAll");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<MatHangModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<KhachHangModel>> GetNewProduct(int Soluong)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "MatHang_moinhat", "@Soluong", Soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KhachHangModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<KhachHangModel>> GetProductBanChay(int sl)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "MatHang_banchay", "@soluong", sl);
                if (!string.IsNullOrEmpty(msgError))

                    throw new Exception(msgError);
                return dt.ConvertTo<KhachHangModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<KhachHangModel>> GetProductOder(int sl)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "MatHang_oder", "@Sl", sl);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KhachHangModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<MatHangModel>> GetProductCategory(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "MatHang_theoloai", "@ LoaiHangID", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<MatHangModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<MatHangModel> GetByIdProduct(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "MatHang_get_by_id", "@Madoan", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<MatHangModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<DonHangBanModel>> GetAllDonHangBan()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "DonHangBanModel_getall");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<DonHangBanModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<MatHangModel> Search(int pageIndex, int pageSize, out long total, int? LoaiHangID = null, int? MatHangID = null, string? TenHang = null, string? option = null, decimal? FromPrice = null, decimal? ToPrice = null)
        {
            string msgError = "";
            total = 0;
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "DonHangBanModel_search",
                    "@page_index", pageIndex,
                    "@MatHangID", MatHangID,
                    "@LoaiHangID", LoaiHangID,
                    "@TenHang", TenHang,
                    "@option", option,
                    "@page_size", pageSize,
                    "@FromPrice", FromPrice,
                    "@ToPrice", ToPrice);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0) total = (long)dt.Rows[0]["RecordCount"];
                return dt.ConvertTo<MatHangModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
