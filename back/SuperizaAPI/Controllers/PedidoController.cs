using Microsoft.EntityFrameworkCore;
using SuperizaAPI.Data;
using Microsoft.AspNetCore.Mvc;
using SuperizaAPI.Dto;
using SuperizaAPI.Models;
using SuperizaAPI.Services.Pedido;

namespace SuperizaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoInterface _pedidoInterface;

        public PedidoController(IPedidoInterface pedidoInterface)
        {
            _pedidoInterface = pedidoInterface;
        }

        // [HttpGet("ListarPedidos")]
        // public async Task<ActionResult<ResponseModel<List<PedidoModel>>>> ListarPedidos()
        // {
        //     var pedidos = await _pedidoInterface.ListarPedidos();
        //     return Ok(pedidos);
        // }

        [HttpPost("CriarPedidos")]
        public async Task<ActionResult<ResponseModel<PedidoModel>>> CriarPedidos(PedidoCriacaoDto pedidoCriacaoDto)
        {
            var pedidos = await _pedidoInterface.CriarPedidos(pedidoCriacaoDto);
            return Ok(pedidos);
        }
    }
}
