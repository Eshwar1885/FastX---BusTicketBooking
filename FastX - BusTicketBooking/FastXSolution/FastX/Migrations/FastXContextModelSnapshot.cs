﻿// <auto-generated />
using System;
using FastX.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FastX.Migrations
{
    [DbContext(typeof(FastXContext))]
    partial class FastXContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FastX.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AdminId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("FastX.Models.AllUser", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Key")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("AllUsers");
                });

            modelBuilder.Entity("FastX.Models.Amenity", b =>
                {
                    b.Property<int>("AmenityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AmenityId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AmenityId");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("FastX.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<DateTime>("BookedForWhichDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("BusId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("FastX.Models.Bus", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusId"), 1L, 1);

                    b.Property<string>("BusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusOperatorId")
                        .HasColumnType("int");

                    b.Property<string>("BusType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalSeats")
                        .HasColumnType("int");

                    b.HasKey("BusId");

                    b.HasIndex("BusOperatorId");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("FastX.Models.BusAmenity", b =>
                {
                    b.Property<int>("BusAmenityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusAmenityId"), 1L, 1);

                    b.Property<int>("AmenityId")
                        .HasColumnType("int");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.HasKey("BusAmenityId");

                    b.HasIndex("AmenityId");

                    b.HasIndex("BusId");

                    b.ToTable("BusAmenities");
                });

            modelBuilder.Entity("FastX.Models.BusOperator", b =>
                {
                    b.Property<int>("BusOperatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusOperatorId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BusOperatorId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("BusOperators");
                });

            modelBuilder.Entity("FastX.Models.BusRoute", b =>
                {
                    b.Property<int>("BusRouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusRouteId"), 1L, 1);

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<string>("JourneyStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.Property<int?>("TimeTableId")
                        .HasColumnType("int");

                    b.HasKey("BusRouteId");

                    b.HasIndex("BusId");

                    b.HasIndex("RouteId");

                    b.HasIndex("TimeTableId");

                    b.ToTable("BusRoute");
                });

            modelBuilder.Entity("FastX.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.HasIndex("BookingId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("FastX.Models.Routee", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteId"), 1L, 1);

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RouteId");

                    b.ToTable("Routees");
                });

            modelBuilder.Entity("FastX.Models.RouteStop", b =>
                {
                    b.Property<int>("RouteStopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteStopId"), 1L, 1);

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.Property<int>("StopId")
                        .HasColumnType("int");

                    b.HasKey("RouteStopId");

                    b.HasIndex("RouteId");

                    b.HasIndex("StopId");

                    b.ToTable("RouteStops");
                });

            modelBuilder.Entity("FastX.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("SeatPrice")
                        .HasColumnType("int");

                    b.HasKey("SeatId", "BusId");

                    b.HasIndex("BusId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("FastX.Models.Stop", b =>
                {
                    b.Property<int>("StopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StopId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sequence")
                        .HasColumnType("int");

                    b.HasKey("StopId");

                    b.ToTable("Stops");
                });

            modelBuilder.Entity("FastX.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"), 1L, 1);

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<float?>("Price")
                        .HasColumnType("real");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("BookingId");

                    b.HasIndex("SeatId", "BusId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("FastX.Models.TimeTable", b =>
                {
                    b.Property<int>("TimeTableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimeTableId"), 1L, 1);

                    b.Property<DateTime?>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TravelDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TimeTableId");

                    b.ToTable("TimeTables");
                });

            modelBuilder.Entity("FastX.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FastX.Models.Admin", b =>
                {
                    b.HasOne("FastX.Models.AllUser", "AllUser")
                        .WithOne("Admin")
                        .HasForeignKey("FastX.Models.Admin", "Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllUser");
                });

            modelBuilder.Entity("FastX.Models.Booking", b =>
                {
                    b.HasOne("FastX.Models.Bus", "Bus")
                        .WithMany("Bookings")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastX.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FastX.Models.Bus", b =>
                {
                    b.HasOne("FastX.Models.BusOperator", "BusOperator")
                        .WithMany("Buses")
                        .HasForeignKey("BusOperatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusOperator");
                });

            modelBuilder.Entity("FastX.Models.BusAmenity", b =>
                {
                    b.HasOne("FastX.Models.Amenity", "Amenity")
                        .WithMany("BusAmenities")
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastX.Models.Bus", "Bus")
                        .WithMany("BusAmenities")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Bus");
                });

            modelBuilder.Entity("FastX.Models.BusOperator", b =>
                {
                    b.HasOne("FastX.Models.AllUser", "AllUser")
                        .WithOne("BusOperator")
                        .HasForeignKey("FastX.Models.BusOperator", "Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllUser");
                });

            modelBuilder.Entity("FastX.Models.BusRoute", b =>
                {
                    b.HasOne("FastX.Models.Bus", "Bus")
                        .WithMany("BusRoute")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastX.Models.Routee", "Route")
                        .WithMany("BusRoute")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastX.Models.TimeTable", "TimeTable")
                        .WithMany("BusRoute")
                        .HasForeignKey("TimeTableId");

                    b.Navigation("Bus");

                    b.Navigation("Route");

                    b.Navigation("TimeTable");
                });

            modelBuilder.Entity("FastX.Models.Payment", b =>
                {
                    b.HasOne("FastX.Models.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("FastX.Models.RouteStop", b =>
                {
                    b.HasOne("FastX.Models.Routee", "Route")
                        .WithMany("RouteStops")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastX.Models.Stop", "Stop")
                        .WithMany("RouteStops")
                        .HasForeignKey("StopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");

                    b.Navigation("Stop");
                });

            modelBuilder.Entity("FastX.Models.Seat", b =>
                {
                    b.HasOne("FastX.Models.Bus", "Bus")
                        .WithMany("Seats")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");
                });

            modelBuilder.Entity("FastX.Models.Ticket", b =>
                {
                    b.HasOne("FastX.Models.Booking", "Booking")
                        .WithMany("Tickets")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastX.Models.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId", "BusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("FastX.Models.User", b =>
                {
                    b.HasOne("FastX.Models.AllUser", "AllUser")
                        .WithOne("User")
                        .HasForeignKey("FastX.Models.User", "Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllUser");
                });

            modelBuilder.Entity("FastX.Models.AllUser", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("BusOperator");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FastX.Models.Amenity", b =>
                {
                    b.Navigation("BusAmenities");
                });

            modelBuilder.Entity("FastX.Models.Booking", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("FastX.Models.Bus", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("BusAmenities");

                    b.Navigation("BusRoute");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("FastX.Models.BusOperator", b =>
                {
                    b.Navigation("Buses");
                });

            modelBuilder.Entity("FastX.Models.Routee", b =>
                {
                    b.Navigation("BusRoute");

                    b.Navigation("RouteStops");
                });

            modelBuilder.Entity("FastX.Models.Stop", b =>
                {
                    b.Navigation("RouteStops");
                });

            modelBuilder.Entity("FastX.Models.TimeTable", b =>
                {
                    b.Navigation("BusRoute");
                });

            modelBuilder.Entity("FastX.Models.User", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
