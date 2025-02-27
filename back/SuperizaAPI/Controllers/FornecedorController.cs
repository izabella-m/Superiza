using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("BuscarFornecedores")]
        public async Task<ActionResult<ResponseModel<List<FornecedorModel>>>> BuscarFornecedores()
        {
            var fornecedores = await _fornecedorInterface.BuscarFornecedores();
            return Ok(fornecedores);
        }
        
    }
}