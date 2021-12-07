using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Nongomaza.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
 : base(options) { }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<SchedulerEvent> Events { get; set; }

    }
}
