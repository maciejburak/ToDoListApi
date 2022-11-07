using Microsoft.AspNetCore.Mvc;

namespace ToDoListv2.Controllers;

public class fd : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}