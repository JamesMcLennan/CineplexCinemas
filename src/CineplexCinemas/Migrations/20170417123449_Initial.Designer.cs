using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CineplexCinemas.Models;

namespace CineplexCinemas.Migrations
{
    [DbContext(typeof(CineplexCinemasContext))]
    [Migration("20170417123449_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cineplex.Models.CineplexMovie", b =>
                {
                    b.Property<int>("CineplexId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CineplexCinemaCineplexId");

                    b.Property<int>("MovieId");

                    b.HasKey("CineplexId");

                    b.HasIndex("CineplexCinemaCineplexId");

                    b.HasIndex("MovieId");

                    b.ToTable("CineplexMovie");
                });

            modelBuilder.Entity("Cineplex.Models.CineplexSite", b =>
                {
                    b.Property<int>("CineplexId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Location");

                    b.Property<string>("LongDescription");

                    b.Property<string>("ShortDescription");

                    b.HasKey("CineplexId");

                    b.ToTable("CineplexSite");
                });

            modelBuilder.Entity("Cineplex.Models.Enquiry", b =>
                {
                    b.Property<int>("EnquiryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Message");

                    b.HasKey("EnquiryId");

                    b.ToTable("Enquiry");
                });

            modelBuilder.Entity("Cineplex.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LongDescription");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title");

                    b.HasKey("MovieId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Cineplex.Models.MovieComingSoon", b =>
                {
                    b.Property<int>("MovieComingSoonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LongDescription");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title");

                    b.HasKey("MovieComingSoonId");

                    b.ToTable("MovieComingSoon");
                });

            modelBuilder.Entity("Cineplex.Models.CineplexMovie", b =>
                {
                    b.HasOne("Cineplex.Models.CineplexSite", "CineplexCinema")
                        .WithMany("CineplexMovie")
                        .HasForeignKey("CineplexCinemaCineplexId");

                    b.HasOne("Cineplex.Models.Movie", "Movie")
                        .WithMany("CineplexMovie")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
