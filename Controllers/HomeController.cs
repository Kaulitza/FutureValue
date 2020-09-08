using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }
    [HttpPost]
    public IActionResult Index (FutureValueModel model)
    {
        ViewBag.FV = model.CalculateFutureValue();
        return View(model);
    }
    }
