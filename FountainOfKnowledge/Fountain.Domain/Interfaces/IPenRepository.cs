using Fountain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain.Domain.Interfaces
{
    public interface IPenRepository
    {
        IQueryable<Pen> GetPens();

        Pen GetPen(int id);

        Task<Pen> GetPenAsync(int id);

        void Add(Pen pen);
    }
}
