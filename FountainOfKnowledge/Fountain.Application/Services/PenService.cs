using Fountain.Application.Interfaces;
using Fountain.Application.ViewModels;
using Fountain.Domain.Commands;
using Fountain.Domain.Core.Bus;
using Fountain.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.Services
{
    public class PenService : IPenService
    {
        private readonly IPenRepository _penRepository;
        private readonly IMediatorHandler _bus;

        public PenService(IPenRepository penRepository, IMediatorHandler bus)
        {
            _penRepository = penRepository;
            _bus = bus;
        }

        public void Create(PenViewModel penViewModel)
        {
            var createPenCommand = new CreatePenCommand(
                    penViewModel.Manufacturer,
                    penViewModel.Model,
                    penViewModel.Description,
                    penViewModel.ImageUrl
                );

            _bus.SendCommand(createPenCommand);
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
