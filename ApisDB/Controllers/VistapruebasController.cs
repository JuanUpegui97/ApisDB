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
<<<<<<< HEAD
        [HttpGet("mv_tipo/{id}")]
=======
        [HttpGet("ventas/{id}")]
>>>>>>> b3600821eece5eadadb88f7a3b03b5ea4ddad402
        public async Task<ActionResult> GetViewTest(string id)
        {
            var result = await _service.GetViewTest(id);

            return Ok(result);
        }

<<<<<<< HEAD
        [HttpGet("ta_clase/{clas}")]
        public async Task<ActionResult> GetViewTestClass(string clas)
        {
            var result = await _service.GetViewTestClass(clas);

            return Ok(result);
        }

=======
>>>>>>> b3600821eece5eadadb88f7a3b03b5ea4ddad402
    }
}
