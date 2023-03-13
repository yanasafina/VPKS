using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SayangHG
{
    public partial class HGContext : DbContext
    {
        public HGContext()
        {
        }
        private static HGContext _context;

        public HGContext(DbContextOptions<HGContext> options)
            : base(options)
        {
        }

        public static HGContext GetContext()
        {
            if (_context == null)
                _context = new HGContext();
            return _context;

        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Hotels> Hotels { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HG;Username=postgres;Password=qwerty");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("booking");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Coming)
                    .HasColumnName("coming")
                    .HasMaxLength(50);

                entity.Property(e => e.Cot)
                    .HasColumnName("cot")
                    .HasMaxLength(30);

                entity.Property(e => e.Food)
                    .HasColumnName("food")
                    .HasMaxLength(30);

                entity.Property(e => e.Fullame)
                    .HasColumnName("fullame")
                    .HasMaxLength(50);

                entity.Property(e => e.Leaving)
                    .HasColumnName("leaving")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Parentname)
                    .HasColumnName("parentname")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(30);

                entity.Property(e => e.Room).HasColumnName("room");

                entity.HasOne(d => d.RoomNavigation)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.Room)
                    .HasConstraintName("booking_room_fkey");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.ToTable("cities");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Cityname)
                    .HasColumnName("cityname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hotels>(entity =>
            {
                entity.ToTable("hotels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .HasColumnName("adress")
                    .HasMaxLength(50);

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Hotelname)
                    .HasColumnName("hotelname")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(30);

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Stars).HasColumnName("stars");

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.Hotels)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("hotels_city_fkey");
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.ToTable("rooms");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beds).HasColumnName("beds");

                entity.Property(e => e.Hotel).HasColumnName("hotel");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);

                entity.HasOne(d => d.HotelNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.Hotel)
                    .HasConstraintName("rooms_hotel_fkey");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fio)
                    .HasColumnName("fio")
                    .HasMaxLength(30);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(30);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(30);

                entity.Property(e => e.Place).HasColumnName("place");

                entity.HasOne(d => d.PlaceNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Place)
                    .HasConstraintName("users_place_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
