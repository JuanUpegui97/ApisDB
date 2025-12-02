using ApisDB.Data;
using ApisDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using ApisDB.Services;

namespace ApisDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VistapruebasController : ControllerBase
    {
        private readonly ConsultService _service;
        public VistapruebasController(ConsultService service)
        {
            _service = service;
        }
        [HttpGet("mv_tipo/{id}")]
        public async Task<ActionResult> GetViewTest(string id)
        {
            var result = await _service.GetViewTest(id);

            return Ok(result);
        }

        [HttpGet("ta_clase/{clas}")]
        public async Task<ActionResult> GetViewTestClass(string clas)
        {
            var result = await _service.GetViewTestClass(clas);

            return Ok(result);
        }

    }
}
