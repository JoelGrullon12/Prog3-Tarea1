using Application.ViewModel.Loan;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Tarea1.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoanViewModel vm)
        {
            double[] tInteres = { 0, 0.22, 0.12, 0.08 };
            //double cantidad = Convert.ToDouble(vm.Monto.ToString().Replace(".", ","));

            double interes = vm.Monto * tInteres[vm.Interes];
            double total = vm.Monto + interes;
            //vm.Monto += vm.Monto * tInteres[vm.Interes];
            double Pagos = total / vm.Cuotas;
            ViewData["Pagos"] = Math.Round(Pagos, 2);

            return View();
        }
    }
}
