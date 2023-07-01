using Microsoft.AspNetCore.Mvc;

namespace BookManager.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    public IActionResult Create()
    {
        return Ok();
    }
}