using AutoMapper;
using Fountain.Application.ViewModels;
using Fountain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Pen, PenViewModel>();
        }
    }
}
