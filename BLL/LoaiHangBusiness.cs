using Models;
using BLL.Interfaces;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using BLL.Interfaces;
using Models;

namespace BLL
{
    public class LoaiHangBusiness : ILoaiHangBusiness
    {
        private ILoaiHangReponsitory _res;
        public LoaiHangBusiness(ILoaiHangReponsitory res)
        {
            _res = res;
        }

        public async Task<bool> Create(LoaiHangModel model)
        {
            return await _res.Create(model);
        }

        public async Task<bool> Delete(int id)
        {
            return await _res.Delete(id);
        }

        public async Task<List<LoaiHangModel>> GetAll()
        {
            return await _res.GetAll();
        }

        public async Task<LoaiHangModel> GetById(int id)
        {
            return await _res.GetById(id);
        }

        public async Task<bool> Update(LoaiHangModel model)
        {
            return await _res.Update(model);
        }
    }
}
