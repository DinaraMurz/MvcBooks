using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcIntro.Models
{
    public class MvcIntroContext : DbContext
    {
        public MvcIntroContext (DbContextOptions<MvcIntroContext> options)
            : base(options)
        {
        }

        public DbSet<MvcIntro.Models.Movie> Movie { get; set; }
    }
}
