using Fountain.Application.Interfaces;
using Fountain.Application.ViewModels;
using Fountain.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.Services
{
    public class PenService : IPenService
    {
        private IPenRepository _penRepository;

        public PenService(IPenRepository penRepository)
        {
            _penRepository = penRepository;
        }

        public PenViewModel GetPens()
        {
            return new PenViewModel()
            {
                Pens = _penRepository.GetPens()
            };
        }
    }
}
