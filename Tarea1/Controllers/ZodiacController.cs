using Application.ViewModel.Zodiac;
using Application.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Tarea1.Controllers
{
	public class ZodiacController : Controller
	{
		public readonly ZodiacViewModel ZodiacSign;

		public ZodiacController()
		{
			ZodiacSign = new();
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(ZodiacViewModel vm)
		{
			ViewData["Dia"]=vm.Dia;
			switch (vm.Mes)
			{
				case (int)Months.Enero:
					if (vm.Dia>=0 && vm.Dia <= 19)
					{
						ViewData["Zodiac"] = "Capricornio";
					}
					else
					{
						ViewData["Zodiac"] = "Acuario";
					}
					break;

				case (int)Months.Febrero:
					if (vm.Dia>=0 && vm.Dia <= 18)
					{
						ViewData["Zodiac"] = "Acuario";
					}
					else
					{
						ViewData["Zodiac"] = "Piscis";
					}
					break;

				case (int)Months.Marzo:
					if (vm.Dia>=0 && vm.Dia <= 20)
					{
						ViewData["Zodiac"] = "Piscis";
					}
					else
					{
						ViewData["Zodiac"] = "Aries";
					}
					break;

				case (int)Months.Abril:
					if (vm.Dia>=0 && vm.Dia <= 19)
					{
						ViewData["Zodiac"] = "Aries";
					}
					else
					{
						ViewData["Zodiac"] = "Tauro";
					}
					break;

				case (int)Months.Mayo:
					if (vm.Dia>=0 && vm.Dia <= 21)
					{
						ViewData["Zodiac"] = "Tauro";
					}
					else
					{
						ViewData["Zodiac"] = "Geminis";
					}
					break;

				case (int)Months.Junio:
					if (vm.Dia>=0 && vm.Dia <= 20)
					{
						ViewData["Zodiac"] = "Geminis";
					}
					else
					{
						ViewData["Zodiac"] = "Cancer";
					}
					break;

				case (int)Months.Julio:
					if (vm.Dia>=0 && vm.Dia <= 22)
					{
						ViewData["Zodiac"] = "Cancer";
					}
					else
					{
						ViewData["Zodiac"] = "Leo";
					}
					break;

				case (int)Months.Agosto:
					if (vm.Dia>=0 && vm.Dia <= 22)
					{
						ViewData["Zodiac"] = "Leo";
					}
					else
					{
						ViewData["Zodiac"] = "Virgo";
					}
					break;

				case (int)Months.Septiembre:
					if (vm.Dia>=0 && vm.Dia <= 22)
					{
						ViewData["Zodiac"] = "Virgo";
					}
					else
					{
						ViewData["Zodiac"] = "Libra";
					}
					break;

				case (int)Months.Octubre:
					if (vm.Dia>=0 && vm.Dia <= 22)
					{
						ViewData["Zodiac"] = "Libra";
					}
					else
					{
						ViewData["Zodiac"] = "Escorpio";
					}
					break;

				case (int)Months.Noviembre:
					if (vm.Dia>=0 && vm.Dia <= 21)
					{
						ViewData["Zodiac"] = "Escorpio";
					}
					else
					{
						ViewData["Zodiac"] = "Sagitario";
					}
					break;

				case (int)Months.Diciembre:
					if (vm.Dia>=0 && vm.Dia <= 21)
					{
						ViewData["Zodiac"] = "Sagitario";
					}
					else
					{
						ViewData["Zodiac"] = "Capricornio";
					}
					break;

				
			}
			return View();
		}
	}
}
