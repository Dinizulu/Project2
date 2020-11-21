using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project2.Models;
using RestSharp;

namespace Project2.Contrellers
{
    [Route("emplyee_details")]

    [Route("employees")]
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        [Route("")]
        [Route("Home")]
        [Route("~/")]

        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        [Route("Registration")]

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [Route("Registration")]
        public IActionResult Registration(User user)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                bool EmailExst = Exist(user.employee_email);

                if(EmailExst)
                {
                    return View(user);
                }
                else
                {
                    user.employee_password = Incription.Crypt(user.employee_password);
                    user.password = Incription.Crypt(user.password);

                    using (DataContext usr = new DataContext())
                    {
                        usr.Add(user);
                        usr.SaveChanges();

                        message = "Registered Successfull You Can Now Log In";
                    }
                }
            }
            ViewBag.Message = message;
            return View(user);
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Login")]
        public IActionResult Login(User user)
        {
            string varify = "";

            using (DataContext log = new DataContext())
            {
                var Is = log.User.Where(a => a.employee_email == user.employee_email).FirstOrDefault();
                if(Is != null)
                {
                    if(string.Compare(Incription.Crypt(user.employee_password),Is.employee_password) == 0)
                    {
                        ModelState.Clear();
                        return View("Interphase");
                    }
                    else
                    {
                        varify = "User info provided not valid";
                    }
                }
                else
                {
                    varify = "User info provided not valid";
                }
            }

            ViewBag.Varify = varify;
            return View();
        }

        [Authorize]
        [Route("Login")]
        public IActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }



        [Route("Index")]

        public IActionResult Index(int Search)
        {
            if(Convert.ToString(Search) != null)
            {
                ViewBag.employees = db.Employees.Where(e => e.EmployeeNumber.ToString().Contains(Search.ToString())).ToList();
                ViewBag.employees = db.Employees.ToList();

                return View();
            }
            else
            {
                ViewBag.employees = db.Employees.ToList();
                return View();
            }

        }

        [HttpGet]
        [Route("delete/{id}")]

        public IActionResult Delete(int EmployeeNumber)
        {
            db.Employees.Remove(db.Employees.Find(EmployeeNumber));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [NonAction]
        public bool Exist(string Email)
        {
            using (DataContext data = new DataContext())
            {
                var Is = data.Login.Where(a => a.employee_email == Email).FirstOrDefault();
                    return Is != null;
            }

        }



    }
}