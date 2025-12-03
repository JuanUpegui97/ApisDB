using ApisDB.Data;
using ApisDB.Models;
using ApisDB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApisDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TxusuariosController : ControllerBase
    {
        private readonly TxusuarioService _service;
        public TxusuariosController(TxusuarioService service)
        {
            _service = service;
        }
        [HttpGet("TXUSUARIOS")]
        public async Task<ActionResult> GetAllTxusuarios()
        {
            var result = await _service.GetAllTxusuarios();
            return Ok(result);
        }
    }
}
