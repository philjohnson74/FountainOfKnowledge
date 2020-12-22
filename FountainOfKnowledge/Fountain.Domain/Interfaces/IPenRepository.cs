using Fountain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Domain.Interfaces
{
    public interface IPenRepository
    {
        IEnumerable<Pen> GetPens();
    }
}
