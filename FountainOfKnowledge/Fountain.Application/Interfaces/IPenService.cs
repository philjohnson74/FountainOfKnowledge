using Fountain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.Interfaces
{
    public interface IPenService
    {
        IEnumerable<PenViewModel> GetPens();
        void Create(PenViewModel penViewModel);
    }
}
