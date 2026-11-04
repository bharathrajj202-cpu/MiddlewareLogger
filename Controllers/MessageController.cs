using Microsoft.AspNetCore.Mvc;

namespace MiddlewareLogger.Controllers;

[ApiController]
[Route("api")]
public class MessageController : ControllerBase
{
    [HttpGet("message")]
    public IActionResult GetMessage()
    {
        return Ok(new
        {
            Message = "Message received",
            Status = "Success"
        });
    }
}