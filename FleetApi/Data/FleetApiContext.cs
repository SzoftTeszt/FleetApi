using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FleetApi.Models;

namespace FleetApi.Data
{
    public class FleetApiContext : DbContext
    {
        public FleetApiContext (DbContextOptions<FleetApiContext> options)
            : base(options)
        {
        }

        public DbSet<FleetApi.Models.Driver> Driver { get; set; } = default!;
    }
}
