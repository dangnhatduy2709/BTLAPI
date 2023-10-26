using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILoaiHangBusiness
    {
        Task<List<LoaiHangModel>> GetAll();

        Task<LoaiHangModel> GetById(int id);

        Task<bool> Create(LoaiHangModel model);
        Task<bool> Update(LoaiHangModel model);

        Task<bool> Delete(int id);
    }
}

