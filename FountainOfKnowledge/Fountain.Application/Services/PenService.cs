using AutoMapper;
using AutoMapper.QueryableExtensions;
using Fountain.Application.Interfaces;
using Fountain.Application.ViewModels;
using Fountain.Domain.Commands;
using Fountain.Domain.Core.Bus;
using Fountain.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain.Application.Services
{
    public class PenService : IPenService
    {
        private readonly IPenRepository _penRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public PenService(IPenRepository penRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _penRepository = penRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(PenViewModel penViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreatePenCommand>(penViewModel));
        }

        public void Update(PenViewModel penViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdatePenCommand>(penViewModel));
        }

        public PenViewModel GetPen(int id)
        {
            var pen = _penRepository.GetPen(id);
            return _autoMapper.Map<PenViewModel>(pen);
        }

        public async Task<PenViewModel> GetPenAsync(int id)
        {
            var pen = await _penRepository.GetPenAsync(id);
            return _autoMapper.Map<PenViewModel>(pen);
        }

        public IEnumerable<PenViewModel> GetPens()
        {
            return _penRepository.GetPens().ProjectTo<PenViewModel>(_autoMapper.ConfigurationProvider);
        }

        public IEnumerable<PenViewModel> GetPens(IPenServiceFilter filter)
        {
            return GetPens().Where(x => x.Manufacturer.Contains(filter.Manufacturer));
        }
    }
}
