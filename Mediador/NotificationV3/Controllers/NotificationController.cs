using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationV3.Services;

namespace NotificationV3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        [HttpGet]
        public IActionResult SaveChages()
        {
            PersistanceService
            return Ok("Guardando datos");
        }
    }
}
