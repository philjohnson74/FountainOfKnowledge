using Fountain.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Infrastructure.Data.Context
{
    public class FountainDBContext : DbContext
    {
        public FountainDBContext(DbContextOptions<FountainDBContext> options) : base(options)
        {
        }

        public DbSet<Pen> Pens { get; set; }
    }
}
