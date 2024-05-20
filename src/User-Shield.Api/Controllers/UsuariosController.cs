using Microsoft.AspNetCore.Mvc;
using User_Shield.Api.Helpers;
using User_Shield.Application;

namespace User_Shield.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioService _suarioService;

        public UsuariosController(UsuarioService usuarioService)
        {
            _suarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var products = await _suarioService.GetAllAsync();
                return Ok(products);
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
