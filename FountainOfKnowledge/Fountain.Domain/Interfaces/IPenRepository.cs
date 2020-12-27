using Fountain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fountain.Domain.Interfaces
{
    public interface IPenRepository
    {
        IQueryable<Pen> GetPens();
        void Add(Pen pen);
    }
}
