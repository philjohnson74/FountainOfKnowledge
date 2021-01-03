using Fountain.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.Filters
{
    public class PenServiceFilter : IPenServiceFilter
    {
        public string Manufacturer { get; set; }
    }
}
