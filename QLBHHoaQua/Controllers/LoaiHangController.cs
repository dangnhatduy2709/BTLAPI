using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace LoaiHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiHangController : ControllerBase
    {
        private ILoaiHangBusiness _LoaiHangBusiness;
        public LoaiHangController(ILoaiHangBusiness LoaiHangBusiness)
        {
            _LoaiHangBusiness = LoaiHangBusiness;
        }

        [Route("create-ldoan")]
        [HttpPost]
        public async Task<LoaiHangModel> Create([FromBody] LoaiHangModel model)
        {
            await _LoaiHangBusiness.Create(model);
            return model;
        }
        [Route("update-ldoan")]
        [HttpPut]
        public async Task<LoaiHangModel> Update([FromBody] LoaiHangModel model)
        {
            await _LoaiHangBusiness.Update(model);
            return model;
        }

        [Route("delete-ldoan")]
        [HttpDelete]
        public async Task<bool> Delete(int id)
        {
            return await _LoaiHangBusiness.Delete(id);
        }
    }
}
