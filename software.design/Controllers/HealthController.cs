using Microsoft.AspNetCore.Mvc;

namespace Software.Design.Models.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;

    public HealthController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetHealthStatus()
    {
        return Ok(new { IsWorking = true });
    }
}
