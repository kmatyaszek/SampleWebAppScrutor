using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleWebAppScrutor.Models;
using SampleWebAppScrutor.Repositories;

namespace SampleWebAppScrutor.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly ICustomerRepository customerRepository;

        public HomeController(IUserRepository userRepository, ICustomerRepository customerRepository)
        {
            this.userRepository = userRepository;
            this.customerRepository = customerRepository;
        }
        
        public IActionResult GetUserName()
        {
            return Json(userRepository.GetUserName(Guid.NewGuid()));
        }

        public IActionResult GetCustomerEmail()
        {
            return Json(customerRepository.GetCustomerEmail(Guid.NewGuid()));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
