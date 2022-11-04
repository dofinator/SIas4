using GrpcService.Models;
using Microsoft.EntityFrameworkCore;

namespace GrpcService.Context
{
    
        public class DbApplicationContext : DbContext
        {
            public DbApplicationContext(DbContextOptions<DbApplicationContext> options) : base(options) { }

            public DbSet<Book> Books { get; set; }
            public DbSet<BookStudentOrder> BookStudentOrders { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                Seed(builder);
                base.OnModelCreating(builder);
            }
            private void Seed(ModelBuilder builder)
            {
                builder
                    .Entity<BookStudentOrder>()
                    .HasKey(x => new { x.StudentId, x.BookId });

                builder
                    .Entity<BookStudentOrder>()
                    .HasOne(x => x.Book)
                    .WithMany(y => y.BookStudentOrders)
                    .HasForeignKey(x => x.BookId);

                builder.Entity<Book>().HasData(
                    new Book
                    {
                        Id = 1,
                        Author = "sumit",
                        Price = 200,
                        Subject = "How to code",
                        Title = "C#",
                        IsAvailable = true,
                        StudyProgrammeId = 1
                    },
                       new Book
                       {
                           Id = 2,
                           Author = "christoffer",
                           Price = 300,
                           Subject = "System integration",
                           Title = "Soa",
                           IsAvailable = true,
                           StudyProgrammeId = 1
                       },

                        new Book
                        {
                            Id = 3,
                            Author = "Author3",
                            Price = 200,
                            Subject = "Development of large systems",
                            Title = "Guide to CI/CD",
                            IsAvailable = true,
                            StudyProgrammeId = 2
                        },
                        new Book
                        {
                            Id = 4,
                            Author = "TestAuthor4",
                            Price = 350,
                            Subject = "Development of large systems",
                            Title = "Guide to Git flow",
                            IsAvailable = true,
                            StudyProgrammeId = 2
                        });
            }
        }
    }

