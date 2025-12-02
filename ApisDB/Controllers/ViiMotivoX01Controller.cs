using ApisDB.Data;
using ApisDB.Models;
using ApisDB.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApisDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViiMotivoX01Controller : ControllerBase
    {
        private readonly ViiMovitoX01Service _service;
        public ViiMotivoX01Controller(ViiMovitoX01Service service)
        {
            _service = service;
        }
        [HttpGet("VII_MOVITO_X01")]
        public async Task<ActionResult> GetAllMovito()
        {
            var result = await _service.GetAllMovito();
            return Ok(result);
        }
        [HttpGet("MV_TIPO/{type}")]
        public async Task<ActionResult> GetMovitoByType(string type)
        {
            var result = await _service.GetMovitoByType(type);
            return Ok(result);
        }
        [HttpGet("MV_FCH/{fechaInicio}/{fechaFin}")]
        public async Task<ActionResult> GetDateToDate(decimal fechaInicio, decimal fechaFin)
        {
            var result = await _service.GetDateToDate(fechaInicio, fechaFin);
            return Ok(result);
        }
        [HttpGet("MV_FCH/{date}")]
        public async Task<ActionResult> GetDate(decimal date)
        {
            var result = await _service.GetDate(date);
            return Ok(result);
        }
        [HttpGet("MV2_ARTIC/{artic}")]
        public async Task<ActionResult> GetMovitoByArtic(string artic)
        {
            var result = await _service.GetMovitoByArtic(artic);
            return Ok(result);
        }
        [HttpGet("MV2_BODEGA1/{bod}")]
        public async Task<ActionResult> GetMovitoByBod(string bod)
        {
            var result = await _service.GetMovitoByBod(bod);
            return Ok(result);
        }
        [HttpGet("DynamySearch/{campo}/{criterio}")]
        public async Task<ActionResult> DynamySearch(string campo, string criterio)
        {
            var result = await _service.DynamySearch(campo, criterio);
            return Ok(result);
        }

    }
}
