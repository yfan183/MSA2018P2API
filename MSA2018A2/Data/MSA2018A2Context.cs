using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSA2018A2.Models
{
    public class MSA2018A2Context : DbContext
    {
        public MSA2018A2Context (DbContextOptions<MSA2018A2Context> options)
            : base(options)
        {
        }

        public DbSet<MSA2018A2.Models.MemeItem> MemeItem { get; set; }
    }
}
