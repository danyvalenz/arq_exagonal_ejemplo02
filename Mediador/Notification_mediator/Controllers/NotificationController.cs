using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notification_mediator.Services;


namespace Notification_mediator.Controllers
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
