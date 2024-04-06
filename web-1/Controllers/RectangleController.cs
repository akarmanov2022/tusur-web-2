using Microsoft.AspNetCore.Mvc;
using web_1.Models;

namespace web_1.Controllers;

public class RectangleController : Controller
{
    [HttpPost]
    public IActionResult CalculateMinArea(List<Rectangle>? rectangles)
    {
        if (rectangles == null || rectangles.Count == 0)
        {
            return BadRequest();
        }

        var min = rectangles.Min(r => r.Area());

        return Ok(min);
    }
}