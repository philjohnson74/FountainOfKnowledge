using Fountain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Application.Interfaces
{
    interface IPenService
    {
        PenViewModel GetPens();
    }
}
