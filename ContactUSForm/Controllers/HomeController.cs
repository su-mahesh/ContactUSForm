
using ContactUSForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContactUSForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContactUSDbContext dbContext;

        public HomeController(ILogger<HomeController> logger, ContactUSDbContext dbContext)
        {
            this.dbContext = dbContext;
            _logger = logger;
        }
        public IActionResult Suggestion()
        {
            return View();
        }
        public IActionResult Submit(ContactUSFormModel contactUSFormModel) 
        {
            if (contactUSFormModel != null)
            {
                dbContext.ContactUsForms.Add(contactUSFormModel);
                dbContext.SaveChanges();
            }
            IEnumerable<ContactUSFormModel> contactUSForms = dbContext.ContactUsForms;
            //  return View("~/Views/Home/Show.cshtml", contactUSForms);
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            IEnumerable<ContactUSFormModel> contactUSForms = dbContext.ContactUsForms;
            return View(contactUSForms);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
