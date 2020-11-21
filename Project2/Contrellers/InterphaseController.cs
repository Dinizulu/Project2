using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Contrellers
{
    public class InterphaseController : Controller
    {
        [Authorize]
        [Route("Interphase")]
        public IActionResult Interphase()
        {
            return View();
        }
    }
}
