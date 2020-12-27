using Fountain.Application.Interfaces;
using Fountain.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fountain.Mvc.Controllers
{
    [Authorize]
    public class PenController : Controller
    {
        private IPenService _penService;

        public PenController(IPenService penService)
        {
            _penService = penService;
        }

        public IActionResult Index()
        {
            return View(_penService.GetPens());
        }
    }
}
