using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Domain.Commands
{
    public class CreatePenCommand : PenCommand
    {
        public CreatePenCommand(string manufacturer, string model, string description, string imageUrl)
        {
            Manufacturer = manufacturer;
            Model = model;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
