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

    [HttpPut]
    public IActionResult Update()
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult FindAll()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult Find()
    {
        return Ok();
    }
}