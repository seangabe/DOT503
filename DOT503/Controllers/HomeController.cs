using DOT503.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DOT503.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController()
        {
            //CircleCI
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new CalculatorModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Calculate(CalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                switch (model.Operator)
                {
                    case "+":
                        model.Result = model.FirstNumber + model.SecondNumber;
                        break;
                    case "-":
                        model.Result = model.FirstNumber - model.SecondNumber;
                        break;
                    case "*":
                        model.Result = model.FirstNumber * model.SecondNumber;
                        break;
                    case "/":
                        if (model.SecondNumber == 0)
                        {
                            ModelState.AddModelError("SecondNumber", "Division by zero is not allowed.");
                        }
                        else
                        {
                            model.Result = model.FirstNumber / model.SecondNumber;
                        }
                        break;
                    case "%":
                        model.Result = model.FirstNumber % model.SecondNumber;
                        break;
                    default:
                        ModelState.AddModelError("Operator", "Invalid operator.");
                        break;
                }
            }
            return View("Index", model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
