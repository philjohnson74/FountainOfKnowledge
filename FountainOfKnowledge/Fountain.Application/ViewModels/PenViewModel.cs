using Fountain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.ViewModels
{
    public class PenViewModel
    {
        IEnumerable<Pen> Pens { get; set; }
    }
}
