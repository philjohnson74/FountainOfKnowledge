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
    public class PenAdminController : Controller
    {
        private IPenService _penService;

        public PenAdminController(IPenService penService)
        {
            _penService = penService;
        }

        public IActionResult Index()
        {
            return View(_penService.GetPens());
        }

        public async Task<IActionResult> Pen(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pen = await _penService.GetPenAsync(id.GetValueOrDefault());
            if (pen == null)
            {
                return NotFound();
            }
            return View(pen);
        }
    }
}