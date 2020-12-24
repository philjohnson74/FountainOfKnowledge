using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Domain.Models
{
    public class Pen
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
