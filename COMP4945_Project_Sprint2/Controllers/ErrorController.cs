using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4945_Project_Sprint2.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            // Here we can manage multiple error status codes, right now it only handles error 404s
            switch(statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Error 404: Sorry, the page you are looking for is not available.";
                    break;
            }
            return View("NotFound");
        }
    }
}
