using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Interface
{
    public partial interface ILoaiHangReponsitory
    {
        Task<List<LoaiHangModel>> GetAll();

        Task<LoaiHangModel> GetById(int id);

        Task<bool> Create(LoaiHangModel model);
        Task<bool> Update(LoaiHangModel model);

        Task<bool> Delete(int id);
    }
}
