using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Domain.Commands
{
    public class UpdatePenCommand : PenCommand
    {
        public int Id { get; set; }
        public UpdatePenCommand(int id, string manufacturer, string model, string description, string imageUrl)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
