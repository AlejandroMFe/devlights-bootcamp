using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GymDataAccess.Models;

namespace GymAPI.Data
{
    public class GymAPIContext : DbContext
    {
        public GymAPIContext (DbContextOptions<GymAPIContext> options)
            : base(options)
        {
        }

        public DbSet<GymDataAccess.Models.Activity> Activity { get; set; } = default!;
    }
}
