using Domain.Entities.Auth;
using Domain.Entities.Book_;
using Domain.Entities.Classification;
using Domain.Entities.Creators;
using Domain.Entities.Relationships;
using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;
using Postgresql.Confugirations.Auth;
using Postgresql.Confugirations.Book_;
using Postgresql.Confugirations.Classification;
using Postgresql.Confugirations.Creators;
using Postgresql.Confugirations.Relationships;
using Postgresql.Confugirations.User_;

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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Auth
			modelBuilder.ApplyConfiguration(new SecurityConfig());
			modelBuilder.ApplyConfiguration(new SessionConfig());

			// Book
			modelBuilder.ApplyConfiguration(new BookConfig());
			modelBuilder.ApplyConfiguration(new RatingConfig());
			modelBuilder.ApplyConfiguration(new ReviewConfig());

			// Classification
			modelBuilder.ApplyConfiguration(new CategoryConfig());

			// Creators
			modelBuilder.ApplyConfiguration(new AuthorConfig());
			modelBuilder.ApplyConfiguration(new PublisherConfig());

			// Relationships
			modelBuilder.ApplyConfiguration(new BookAuthorConfig());

			// User
			modelBuilder.ApplyConfiguration(new MarkedBookConfig());
			modelBuilder.ApplyConfiguration(new UserConfig());

		}

	}
}
