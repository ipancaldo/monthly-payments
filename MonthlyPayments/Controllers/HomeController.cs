using Microsoft.AspNetCore.Mvc;
using MonthlyPayments.Models;
using MonthlyPayments.Service;
using System.Diagnostics;

namespace MonthlyPayments.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGroceryService _groceryService;

        public HomeController(IGroceryService groceryService)
        {
            _groceryService = groceryService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                return View(await _groceryService.GetGroceryResume());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IActionResult> UpdatePayment(string quantity, bool isCreditCard)
        {
            try
            {
                await _groceryService.UpdatePayment(quantity, isCreditCard);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw;
            }
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