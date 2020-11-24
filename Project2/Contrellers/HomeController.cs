using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        [Route("ViewEmployee")]
        public IActionResult ViewEmployee()
        {
            ViewBag.employees = db.Employees.ToList();
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
            try
            {
                string message = "";
                if (ModelState.IsValid)
                {
                    bool EmailExst = Exist(user.employee_email);

                    if (EmailExst)
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
                ModelState.Clear();
                return View(user);
            }
            catch
            {
                ViewBag.Message = "Erro trying to enter you data try again";
                return View();
            }

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
            try
            {
                string varify = "";

                using (DataContext log = new DataContext())
                {
                    var Is = log.User.Where(a => a.employee_email == user.employee_email).FirstOrDefault();
                    var rle = log.User.Where(a => a.employee_role == user.employee_role).FirstOrDefault();
                    if (rle != null)
                    {
                        if (user.employee_role == "Employee" && string.Compare(Incription.Crypt(user.employee_password), Is.employee_password) == 0)
                        {
                            ViewBag.Emp = user.employee_password;
                            ModelState.Clear();
                            return View("Interphase");
                        }
                        else if (user.employee_role == "Admin" && string.Compare(Incription.Crypt(user.employee_password), Is.employee_password) == 0)
                        {
                            ViewBag.Admin = user.employee_password;
                            return View("AdminV");
                        }
                        else if (user.employee_role == "Manager" && string.Compare(Incription.Crypt(user.employee_password), Is.employee_password) == 0)
                        {
                            ViewBag.Mananger = user.employee_password;
                            return View("Manager");
                        }
                        else
                        {
                            ModelState.Clear();
                            varify = "User info provided not valid";
                        }
                    }
                    else
                    {
                        ModelState.Clear();
                        varify = "User info provided not valid";
                    }
                }

                ViewBag.Varify = varify;
                return View();
            }
            catch
            {
                return View();
            }
           
        }

        [HttpGet]
        [Route("UserInfo")]
        public IActionResult UserInfo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("UserInfo")]
        public IActionResult UserInfo(Employee userData)
        {
            try
            {
                ViewBag.Count = db.Employees.OrderByDescending(a => a.EmployeeNumber).FirstOrDefault().ToString();
                if (ModelState.IsValid)
                {
                    ViewBag.Count = db.Employees.OrderByDescending(a => a.EmployeeNumber).FirstOrDefault();
                    db.Add(userData);
                    db.SaveChanges();
                    return View("Interphase");
                }
                else
                {
                    ViewBag.Count = db.Employees.OrderByDescending(a => a.EmployeeNumber).FirstOrDefault();
                    return View("UserInfo");
                }

            }
            catch
            {
                return View();
            }
        }


        //Editting User By The Manager

        [HttpGet]
        [Route("EditUser/{id}")]

        public IActionResult EditUser(int id)
        {
            using(DataContext data = new DataContext())
            {
                return View(data.Employees.Where(a => a.EmployeeNumber == id).FirstOrDefault());
            }

        }

        [HttpPost]
        [Route("EditUser/{id}")]
        public IActionResult EditUser(int id,Employee Usr)
        {
    
            try
            {
                using (DataContext ds = new DataContext())
                {
                    ds.Entry(Usr).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    ds.SaveChanges();
                }
                return RedirectToAction("ViewEmployee");
            }
            catch
            {
                return View();
            }
        }

        //Deleting A Rocord of User Data

        [HttpGet]
        [Route("Delete/{id}")]

        public IActionResult Delete(int id)
        {
            using(DataContext ds = new DataContext())
            {
                return View(ds.Employees.Where(a => a.EmployeeNumber == id).FirstOrDefault());
            }
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id,FormCollection keyValues )
        {
            try
            {
                using (DataContext ds = new DataContext())
                {
                    Employee employee = ds.Employees.Where(a => a.EmployeeNumber == id).FirstOrDefault();
                    ds.Employees.Remove(employee);
                    ds.SaveChanges();
                }
                return RedirectToAction("ViewEmployee");
            }
            catch
            {
                return View();
            }

        }

        [HttpGet]
        [Route("Varyfy/{id}")]
        public IActionResult Varify(int id)
        { 
            using(DataContext ds = new DataContext())
            {
                return View(ds.Employees.Where(a => a.EmployeeNumber == id).FirstOrDefault());
            }
        }


        [NonAction]
        public bool Exist(string Email)
        {
            using (DataContext data = new DataContext())
            {
                var Is = data.User.Where(a => a.employee_email == Email).FirstOrDefault();
                    return Is != null;
            }

        }



    }
}