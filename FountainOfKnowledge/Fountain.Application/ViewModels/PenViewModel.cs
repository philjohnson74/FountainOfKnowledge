using Fountain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.ViewModels
{
    public class PenViewModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
