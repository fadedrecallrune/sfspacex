using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ShittyFakeSpaceX.Models;

namespace ShittyFakeSpaceX.Migrations
{
    [DbContext(typeof(FlightContext))]
    partial class FlightContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShittyFakeSpaceX.Models.Flight", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FlightNumber");

                    b.Property<string>("Planet")
                        .IsRequired();

                    b.Property<string>("Station")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<string>("Terminal");

                    b.Property<string>("Time");

                    b.HasKey("ID");

                    b.ToTable("Flights");
                });
        }
    }
}
