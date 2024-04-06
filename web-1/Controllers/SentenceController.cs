using Microsoft.AspNetCore.Mvc;

namespace web_1.Controllers;

public class SentenceController : Controller
{
    [HttpPost]
    public IActionResult CountSpaces(string sentence)
    {
        if (string.IsNullOrEmpty(sentence))
        {
            return BadRequest();
        }

        var spaceCount = sentence.Split(' ').Length - 1;

        return Ok(spaceCount.ToString());
    }
}