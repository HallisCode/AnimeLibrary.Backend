using Domain.Entities;
using Domain.Entities.Auth;
using Domain.Entities.Book_;
using Domain.Entities.Classification;
using Domain.Entities.Creators;
using Domain.Entities.Relationships;
using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;


namespace Postgresql
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Security> Securities { get; set; }
		public DbSet<Session> Sessions { get; set; }

		public DbSet<Book> Books { get; set; }
		public DbSet<Rating> Ratings { get; set; }
		public DbSet<Review> Reviews { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<Author> Authors { get; set; }
		public DbSet<Publisher> Publishers { get; set; }

		public DbSet<User> Users { get; set; }
		public DbSet<MarkedBook> MarkedBooks { get; set; }


		// Entity relationships
		public DbSet<BookAuthor> BookAuthors { get; set; }


	}
}
