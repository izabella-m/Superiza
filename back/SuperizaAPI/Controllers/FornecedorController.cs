using Microsoft.AspNetCore.Mvc;
using SuperizaAPI.Dto;
using SuperizaAPI.Models;
using SuperizaAPI.Services.Fornecedor;

namespace SuperizaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorInterface _fornecedorInterface;

        public FornecedorController(IFornecedorInterface fornecedorInterface)
        {
            _fornecedorInterface = fornecedorInterface;
        }

        [HttpGet("ListarFornecedores")]
        public async Task<ActionResult<ResponseModel<List<FornecedorModel>>>> ListarFornecedores()
        {
            var fornecedores = await _fornecedorInterface.ListarFornecedores();
            return Ok(fornecedores);
        }

        [HttpPost("CriarFornecedores")]
        public async Task<ActionResult<ResponseModel<FornecedorModel>>> CriarFornecedores(FornecedorCriacaoDto fornecedorCriacaoDto)
        {
            var fornecedores = await _fornecedorInterface.CriarFornecedores(fornecedorCriacaoDto);
            return Ok(fornecedores);
        }
        
        [HttpPut("EditarFornecedores")]
        public async Task<ActionResult<ResponseModel<List<FornecedorModel>>>> EditarFornecedores(FornecedorEdicaoDto fornecedorEdicaoDto)
        {
            var fornecedores = await _fornecedorInterface.EditarFornecedores(fornecedorEdicaoDto);
            return Ok(fornecedores);
        }   
        
        [HttpDelete("DeletarFornecedores")]
        public async Task<ActionResult<ResponseModel<List<FornecedorModel>>>> DeletarFornecedores(int idFornecedores)
        {
            var fornecedores = await _fornecedorInterface.DeletarFornecedores(idFornecedores);
            return Ok(fornecedores);
        } 
    }
}