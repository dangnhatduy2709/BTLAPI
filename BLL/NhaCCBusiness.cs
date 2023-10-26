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
    public partial class NhaCCBusiness : INhaCCBusiness
    {
        private readonly INhaCCRepository _res;
        public NhaCCBusiness(INhaCCRepository res)
        {
            _res = res;
        }
        public async Task<List<NhaCCModel>> GetAllNhaCC()
        {
            return await _res.GetAllNhaCC();
        }
    }
}
