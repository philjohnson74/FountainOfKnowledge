using Fountain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fountain.Application.Interfaces
{
    public interface IPenService
    {
        IEnumerable<PenViewModel> GetPens();

        IEnumerable<PenViewModel> GetPens(IPenServiceFilter filter);

        PenViewModel GetPen(int id);

        Task<PenViewModel> GetPenAsync(int id);

        void Create(PenViewModel penViewModel);

        void Update(PenViewModel penViewModel);
    }
}
