using System.Diagnostics;
using ElRinconDelMate.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElRinconDelMate.Controllers
{
    public class MantenimientoController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
