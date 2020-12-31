using Fountain.Domain.Interfaces;
using Fountain.Domain.Models;
using Fountain.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain.Infrastructure.Data.Repository
{
    public class PenRepository : IPenRepository
    {
        private FountainDBContext _context;

        public PenRepository(FountainDBContext context)
        {
            _context = context;
        }

        public void Add(Pen pen)
        {
            _context.Pens.Add(pen);
            _context.SaveChanges();
        }

        public Pen GetPen(int id)
        {
            return _context.Pens.Find(id);
        }

        public async Task<Pen> GetPenAsync(int id)
        {
            return await _context.Pens.FindAsync(id);
        }

        public IQueryable<Pen> GetPens()
        {
            return _context.Pens;
        }
    }
}
