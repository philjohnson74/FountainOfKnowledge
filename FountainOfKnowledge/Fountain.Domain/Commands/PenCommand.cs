using System;
using System.Collections.Generic;
using System.Text;
using Fountain.Domain.Core.Commands;

namespace Fountain.Domain.Commands
{
    public abstract class PenCommand : Command
    {
        public string Manufacturer { get; protected set; }
        public string Model { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}