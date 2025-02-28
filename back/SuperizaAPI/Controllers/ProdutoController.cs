using SuperizaAPI.Models;
using SuperizaAPI.Services.Produto;
using Microsoft.AspNetCore.Mvc;
using SuperizaAPI.Dto;


namespace SuperizaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoInterface _produtoInterface;

        public ProdutoController(IProdutoInterface produtoInterface)
        {
            _produtoInterface = produtoInterface;
        }

        [HttpGet("ListarProdutos")]
        public async Task<ActionResult<ResponseModel<List<ProdutoModel>>>> ListarProdutos()
        {
            var produtos = await _produtoInterface.ListarProdutos();
            return Ok(produtos);
        }
        
        [HttpPost("CriarProdutos")]
        public async Task<ActionResult<ResponseModel<ProdutoModel>>> CriarProdutos(ProdutoCriacaoDto produtoCriacaoDto)
        {
            var produtos = await _produtoInterface.CriarProdutos(produtoCriacaoDto);
            return Ok(produtos);
        }
    }
}