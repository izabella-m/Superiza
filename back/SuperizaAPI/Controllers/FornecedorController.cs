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

        [HttpGet("ListarFornecedores")]
        public async Task<ActionResult<ResponseModel<List<FornecedorModel>>>> ListarFornecedores()
        {
            var fornecedores = await _fornecedorInterface.ListarFornecedores();
            return Ok(fornecedores);
        }
        
    }
}