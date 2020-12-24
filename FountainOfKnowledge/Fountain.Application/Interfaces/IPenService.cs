using Fountain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.Interfaces
{
    public interface IPenService
    {
        PenViewModel GetPens();
        void Create(PenViewModel penViewModel);
    }
}
