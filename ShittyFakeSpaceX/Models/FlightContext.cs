using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShittyFakeSpaceX.Models
{
    public class FlightContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }

        public FlightContext(DbContextOptions<FlightContext> options) : base(options)
        {

        }
    }
}
