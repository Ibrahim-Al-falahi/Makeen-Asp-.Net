﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MuscatAirport.Context;

#nullable disable

namespace MuscatAirport.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MuscatAirport.Models.Airline_Module.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Representer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("airlines", (string)null);
                });

            modelBuilder.Entity("MuscatAirport.Models.Airline_Module.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AirlineId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ArrivalTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DepartureTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirlineId");

                    b.ToTable("flights", (string)null);
                });

            modelBuilder.Entity("MuscatAirport.Models.Checkpoint_Module.Checkpoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassengerCapacity")
                        .HasColumnType("int");

                    b.Property<int>("TerminalId")
                        .HasColumnType("int");

                    b.Property<string>("TerminalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("checkpoints", (string)null);
                });

            modelBuilder.Entity("MuscatAirport.Models.Checkpoint_Module.Officer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CheckpointId")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CheckpointId");

                    b.ToTable("officers", (string)null);
                });

            modelBuilder.Entity("MuscatAirport.Models.Passenger_Module.Baggage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<int>("TrackingNumber")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PassengerId");

                    b.ToTable("baggages", (string)null);
                });

            modelBuilder.Entity("MuscatAirport.Models.Passenger_Module.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("DOB")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassportNumber")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("passengers", (string)null);
                });

            modelBuilder.Entity("MuscatAirport.Models.Terminal_Module.Gate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AirlineId")
                        .HasColumnType("int");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("TerminalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AirlineId");

                    b.HasIndex("TerminalId");

                    b.ToTable("gates", (string)null);
                });

            modelBuilder.Entity("MuscatAirport.Models.Terminal_Module.Terminal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("terminals", (string)null);
                });

            modelBuilder.Entity("MuscatAirport.Models.Airline_Module.Flight", b =>
                {
                    b.HasOne("MuscatAirport.Models.Airline_Module.Airline", "Airline")
                        .WithMany("FlightsList")
                        .HasForeignKey("AirlineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airline");
                });

            modelBuilder.Entity("MuscatAirport.Models.Checkpoint_Module.Checkpoint", b =>
                {
                    b.HasOne("MuscatAirport.Models.Terminal_Module.Terminal", "Terminal")
                        .WithMany("CheckpointsList")
                        .HasForeignKey("TerminalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("MuscatAirport.Models.Checkpoint_Module.Officer", b =>
                {
                    b.HasOne("MuscatAirport.Models.Checkpoint_Module.Checkpoint", "Checkpoint")
                        .WithMany("OfficersList")
                        .HasForeignKey("CheckpointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Checkpoint");
                });

            modelBuilder.Entity("MuscatAirport.Models.Passenger_Module.Baggage", b =>
                {
                    b.HasOne("MuscatAirport.Models.Passenger_Module.Passenger", "Passenger")
                        .WithMany("BaggagesList")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("MuscatAirport.Models.Passenger_Module.Passenger", b =>
                {
                    b.HasOne("MuscatAirport.Models.Airline_Module.Flight", "Flight")
                        .WithMany("PassengersList")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("MuscatAirport.Models.Terminal_Module.Gate", b =>
                {
                    b.HasOne("MuscatAirport.Models.Airline_Module.Airline", "Airline")
                        .WithMany("GatesList")
                        .HasForeignKey("AirlineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MuscatAirport.Models.Terminal_Module.Terminal", "Terminal")
                        .WithMany("GatesList")
                        .HasForeignKey("TerminalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airline");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("MuscatAirport.Models.Airline_Module.Airline", b =>
                {
                    b.Navigation("FlightsList");

                    b.Navigation("GatesList");
                });

            modelBuilder.Entity("MuscatAirport.Models.Airline_Module.Flight", b =>
                {
                    b.Navigation("PassengersList");
                });

            modelBuilder.Entity("MuscatAirport.Models.Checkpoint_Module.Checkpoint", b =>
                {
                    b.Navigation("OfficersList");
                });

            modelBuilder.Entity("MuscatAirport.Models.Passenger_Module.Passenger", b =>
                {
                    b.Navigation("BaggagesList");
                });

            modelBuilder.Entity("MuscatAirport.Models.Terminal_Module.Terminal", b =>
                {
                    b.Navigation("CheckpointsList");

                    b.Navigation("GatesList");
                });
#pragma warning restore 612, 618
        }
    }
}
