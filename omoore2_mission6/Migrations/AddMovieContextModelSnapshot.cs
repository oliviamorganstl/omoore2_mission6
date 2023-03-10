// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using omoore2_mission6.Models;

namespace omoore2_mission6.Migrations
{
    [DbContext(typeof(AddMovieContext))]
    partial class AddMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("omoore2_mission6.Models.AddResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 1,
                            Director = "Joss Whedon",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Serenity",
                            Year = 2005
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 2,
                            Director = "Guy Ritchie",
                            Edited = true,
                            Lent = "",
                            Notes = "",
                            Rating = "R",
                            Title = "Snatch",
                            Year = 2001
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 3,
                            Director = "Phil Alden Robinson",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Sneakers",
                            Year = 1992
                        });
                });

            modelBuilder.Entity("omoore2_mission6.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("omoore2_mission6.Models.AddResponse", b =>
                {
                    b.HasOne("omoore2_mission6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
