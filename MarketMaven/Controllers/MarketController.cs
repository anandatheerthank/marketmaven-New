using MarketMaven.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketMaven.Controllers
{
    public class MarketController : Controller
    {
        MarketDBContext dbContext;
        public MarketController(MarketDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult RegisterForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterForm(EmployeeLogin login)
        {
            if (ModelState.IsValid)
            {
                var r = dbContext.Employees.Where
                        (l => l.Email == login.Email).FirstOrDefault();

                if (r != null)
                    return RedirectToAction("GreetNote", login);

                return View();
            }
            return View();
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Email == employee.Password)
                {
                    ViewBag.Message = "Email and Password should not be the same";
                }
                else
                {
                    dbContext.Employees.Add(employee);
                    dbContext.SaveChanges();
                    return RedirectToAction("RegisterForm");
                }

                return View();
            }

            return View();
        }

        public IActionResult GreetNote(EmployeeLogin model)
        {
            return View(model);
        }
    }
}
