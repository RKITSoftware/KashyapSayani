using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationCalculatorDemo.Models;

namespace WebApplicationCalculatorDemo.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new Calculator());
        }

        
        [HttpPost]
        public ActionResult Index(Calculator calc, string calculate)
        {
            if(calculate=="add")
            {
                calc.result = calc.number1 + calc.number2;
            }
            else if(calculate == "minus")
            {
                    calc.result = calc.number1 - calc.number2;
            }
            else if (calculate == "mul")
            {
                calc.result = calc.number1 * calc.number2;
            }
            else
            {
                calc.result = calc.number1 / calc.number2;
            }

            return View(calc);
        }
    }
}