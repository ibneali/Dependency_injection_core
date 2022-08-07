using Dependency_injection_core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_injection_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IEmployee _Interdobj;

        public HomeController(ILogger<HomeController> logger, IEmployee Idobj)
        {
            _logger = logger;
            _Interdobj = Idobj;
        }

        public IActionResult Index()
        {
            var res = _Interdobj.getall();

           
            return View(res);
        }
        [HttpGet]
        public IActionResult edit(int id)
        {
            var res = _Interdobj.getbyId(id);
            return View("updatadata",res);
        }

        public IActionResult createdata()
        {
            return View();
        }
        [HttpPost]
            public IActionResult createdata(Employee obj)
        {
            _Interdobj?.create(obj);
            _Interdobj?.save();
            return View("Index");
        }
        [HttpGet]
        public IActionResult deletedata(int id)
        {
            _Interdobj.dalete(id);
            _Interdobj.save();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult updatadata(Employee obj)
        {
            _Interdobj.update(obj);
            _Interdobj.save();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult updatadata()
        {
            return View();
        }

       
    }
}
