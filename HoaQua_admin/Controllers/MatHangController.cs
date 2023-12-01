using BLL.Interfaces;
using DAL.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace HoaQua_admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatHangController : ControllerBase
    {
        private readonly IMatHangBusiness _MatHangBusiness;
        private readonly IToolRepository _toolRepository;
        public MatHangController(IMatHangBusiness MatHangBusiness, IToolRepository toolRepository)
        {
            _MatHangBusiness = MatHangBusiness;
            _toolRepository = toolRepository;
        }


        [Route("Create_MatHang")]
        [HttpPost]
        public async Task<MatHangModel> Create([FromBody] MatHangModel model)
        {
            await _MatHangBusiness.Create(model);
            return model;
        }
        [Route("Update_MatHang")]
        [HttpPut]
        public async Task<MatHangModel> Update([FromBody] MatHangModel model)
        {
            await _MatHangBusiness.Update(model);
            return model;
        }
        [Route("Delete_MatHang")]
        [HttpDelete]
        public async Task<bool> Delete(int id)
        {
            return await _MatHangBusiness.Delete(id);
        }
        [Route("upload")]
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {

            var fileName = _toolRepository.SaveFile(file);
            return Ok(new { FileName = fileName.Result });
        }



    }
}
