using Fountain.Domain.Interfaces;
using Fountain.Domain.Models;
using Fountain.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Infrastructure.Data.Repository
{
    public class PenRepository : IPenRepository
    {
        private FountainDBContext _context;

        public PenRepository(FountainDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Pen> GetPens()
        {
            return _context.Pens;
        }
    }
}
