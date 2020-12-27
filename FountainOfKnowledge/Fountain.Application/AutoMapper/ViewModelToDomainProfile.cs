using AutoMapper;
using Fountain.Application.ViewModels;
using Fountain.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<PenViewModel, CreatePenCommand>()
                .ConvertUsing(c => new CreatePenCommand(c.Manufacturer, c.Model, c.Description, c.ImageUrl));
        }
    }
}
