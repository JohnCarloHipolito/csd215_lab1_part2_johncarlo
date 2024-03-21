using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csd215_lab1_part2_johncarlo.Models;

namespace csd215_lab1_part2_johncarlo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(double firstNum, double secondNum, string mathOp)
    {
        if (mathOp == "add")
        {
            ViewBag.Result = $"{firstNum} + {secondNum} = {firstNum + secondNum}";
        }
        else if (mathOp == "subtract")
        {
            ViewBag.Result = $"{firstNum} - {secondNum} = {firstNum - secondNum}";
        }
        else if (mathOp == "multiply")
        {
            ViewBag.Result = $"{firstNum} * {secondNum} = {firstNum * secondNum}";
        }
        else if (mathOp == "divide")
        {
            if (secondNum == 0)
            {
                ViewBag.Result = "Dividing to 0 will result to infinite value";
            }
            else
            {
                ViewBag.Result = $"{firstNum} / {secondNum} = {firstNum / secondNum}";
            }
        }
        else
        {
            ViewBag.Result = $"%A{mathOp} not supported";
        }

        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}