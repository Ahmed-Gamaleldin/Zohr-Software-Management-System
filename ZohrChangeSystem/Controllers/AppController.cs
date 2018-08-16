using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ZohrChangeSystem.Data;
using ZohrChangeSystem.Data.Entities;
using ZohrChangeSystem.ViewModels;

namespace ZohrChangeSystem.Controllers
{
    public class AppController : Controller

    {


        private readonly ZohrContext _context;

        public AppController(ZohrContext context)
        {
            _context = context;
        }


        [HttpGet("login")]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(UserViewModel model)
        {
            foreach (User c in _context.users)
            {
                if (c.username == model.username && c.password == model.password)
                    return RedirectToAction("Show", "App");
            }
            return View();
        }


        public IActionResult Show()
        {
            return View();
        }

        public IActionResult ShowById(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ChangeForm model)
        {
            model.date = DateTime.Now.ToString("dd/mm/yyyy");
            _context.changeForms.Add(model);
            model.status = "Waiting Approval";
            _context.SaveChanges();
            return RedirectToAction("ListAll", "App");
        }

        public IActionResult ApproveReject()
        {
            return View();
        }

        public IActionResult ListAll()
        {
            var results = from c in _context.changeForms
                          orderby c.category
                          select c;
            return View(results.ToList());

        }
    }
}