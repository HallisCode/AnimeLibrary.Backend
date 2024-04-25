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
		public DbSet<Security> Security { get; set; }
		public DbSet<Session> Session { get; set; }

		public DbSet<Book> Book { get; set; }
		public DbSet<Rating> Rating { get; set; }
		public DbSet<Review> Review { get; set; }

		public DbSet<Category> Category { get; set; }

		public DbSet<Author> Author { get; set; }
		public DbSet<Publisher> Publisher { get; set; }

		public DbSet<User> Users { get; set; }
		public DbSet<MarkedBook> MarkedBook { get; set; }


		// Entity relationships
		public DbSet<BookAuthor> BookAuthor { get; set; }

		// Logic
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

	}
}
