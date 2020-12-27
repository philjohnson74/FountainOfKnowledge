using Fountain.Application.Interfaces;
using Fountain.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fountain.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PenController : ControllerBase
    {
        private readonly IPenService _penService;

        public PenController(IPenService penService)
        {
            _penService = penService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PenViewModel penViewModel)
        {
            _penService.Create(penViewModel);

            return Ok(penViewModel);
        }
    }
}
