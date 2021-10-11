using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesApp.Controllers
{
    public class DocumentationNotes : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
