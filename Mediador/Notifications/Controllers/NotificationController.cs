using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notifications.Services;


namespace Notifications.Controllers
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
