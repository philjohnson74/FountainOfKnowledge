using Fountain.Domain.Commands;
using Fountain.Domain.Interfaces;
using Fountain.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fountain.Domain.CommandHandlers
{
    public class PenCommandHandler : IRequestHandler<CreatePenCommand, bool>
    {
        private readonly IPenRepository _penRepository;

        public PenCommandHandler(IPenRepository penRepository)
        {
            _penRepository = penRepository;
        }

        public Task<bool> Handle(CreatePenCommand request, CancellationToken cancellationToken)
        {
            var pen = new Pen()
            {
                Manufacturer = request.Manufacturer,
                Model = request.Model,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            _penRepository.Add(pen);

            return Task.FromResult(true);
        }
    }
}
