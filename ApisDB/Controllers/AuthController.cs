using ApisDB.Data;
using ApisDB.Models;
using ApisDB.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Authorization;


namespace ApisDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _service;

        public AuthController(AuthService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginDto login)
        {
            var token = await _service.Login(login);

            if (token == null)
            {
                return Unauthorized("Usuario o contraseña incorrectos.");
            }
            return Ok(new {Token = token});
        }
    }
}
