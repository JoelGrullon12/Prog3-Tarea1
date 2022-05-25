using Application.ViewModel.Currency;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Tarea1.Controllers
{
    public class CurrencyController : Controller
    {
        double[] de = { 0.018135654697134, 1, 1.07 };
        double[] a = { 55.14, 1, 0.93 };
        string[] currencies = { "Peso(s)", "Dolar(es)", "Euro(s)" };
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CurrencyViewModel vm)
        {
            //double cantidad = Convert.ToDouble(vm.Cantidad.ToString().Replace(".", ","));
            //double cantidad = vm.Cantidad;
            //double converted = vm.Cantidad * de[vm.De - 1] * a[vm.A - 1];
            ViewData["Convertion"] = Math.Round(vm.Cantidad * de[vm.De - 1] * a[vm.A - 1], 2);
            ViewData["From"] = currencies[vm.De - 1];
            ViewData["To"] = currencies[vm.A - 1];
            //ViewData["Cantidad"] = vm.Cantidad;

            //ViewData["De"] = de[vm.De - 1];
            //ViewData["A"] = a[vm.A - 1];
            return View(vm);
        }
    }
}
