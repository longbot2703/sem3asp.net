namespace BookService.Migrations
{
    using BookService.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Data.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Data.BookServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Authors.AddOrUpdate(
                    p => p.Id,

                    new Author { Id = 1, Name = "Tuan"},
                    new Author { Id = 2, Name = "Tien"},
                    new Author { Id = 3, Name = "Duc"}
                );

            context.Books.AddOrUpdate(
                    c => c.Id,
                    new Book { Id= 1, Title = "Toan", Year = 1990, AuthorId = 1, Prince = 8, Genre = "sach truyen"},
                    new Book { Id = 2, Title = "Van", Year = 1980, AuthorId = 2, Prince = 10, Genre = "Vanaaaa"},
                    new Book { Id = 3, Title = "Tieng Anh", Year = 1989, AuthorId = 3, Prince = 8, Genre = "haaaa"},
                    new Book { Id = 4, Title = "Dao duc", Year = 1998, AuthorId = 1, Prince = 6, Genre = "hiihi" }
                );
        }
    }
}
