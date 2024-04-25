using Database.IRepositories.Auth;
using Database.IRepositories.Book_;
using Database.IRepositories.Classification;
using Database.IRepositories.Creators;
using Database.IRepositories.User_;
using Database.IUnitOfWork;
using Postgresql.Repositories.Auth;
using Postgresql.Repositories.Book_;
using Postgresql.Repositories.Creators;
using Postgresql.Repositories.User_;
using System.Threading.Tasks;

namespace Postgresql.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private ApplicationDbContext dbContext;


		private ISecurityRepository security;
		private ISessionRepository session;

		private IBookRepository book;
		private IRatingRepository rating;
		private IReviewRepository review;

		private ICategoryRepository category;

		private IAuthorRepository author;
		private IPublisherRepository publisher;

		private IMarkedBookRepository markedBook;
		private IUserRepository user;


		public ISecurityRepository Security
		{
			get
			{
				if (security is null) security = new SecurityRepository(dbContext);

				return security;
			}
		}
		public ISessionRepository Session
		{
			get
			{
				if (session is null) session = new SessionRepository(dbContext);

				return session;
			}
		}

		public IBookRepository Book
		{
			get
			{
				if (book is null) book = new BookRepository(dbContext);

				return book;
			}
		}
		public IRatingRepository Rating
		{
			get
			{
				if (rating is null) rating = new RatingRepository(dbContext);

				return rating;
			}
		}
		public IReviewRepository Review
		{
			get
			{
				if (review is null) review = new ReviewRepository(dbContext);

				return review;
			}
		}

		public ICategoryRepository Category
		{
			get
			{
				if (category is null) category = new CategoryRepository(dbContext);

				return category;
			}
		}

		public IAuthorRepository Author
		{
			get
			{
				if (author is null) author = new AuthorRepository(dbContext);

				return author;
			}
		}
		public IPublisherRepository Publisher
		{
			get
			{
				if (publisher is null) publisher = new PublisherRepository(dbContext);

				return publisher;
			}
		}

		public IMarkedBookRepository MarkedBook
		{
			get
			{
				if (markedBook is null) markedBook = new MarkedBookRepository(dbContext);

				return markedBook;
			}
		}
		public IUserRepository User
		{
			get
			{
				if (user is null) user = new UserRepository(dbContext);

				return user;
			}
		}


		public UnitOfWork(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task<ITransaction> BeginTransactionAsync()
		{
			return new Transaction(await dbContext.Database.BeginTransactionAsync());
		}
	}
}
