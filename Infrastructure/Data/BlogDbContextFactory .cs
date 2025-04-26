using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Infrastructure.Data;

namespace Infrastructure.Factories
{
	public class BlogDbContextFactory : IDesignTimeDbContextFactory<BlogDbContext>
	{
		public BlogDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<BlogDbContext>();

			// Ovo odgovara onome iz appsettings.json
			optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=mas;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=True");

			return new BlogDbContext(optionsBuilder.Options);
		}
	}
}
