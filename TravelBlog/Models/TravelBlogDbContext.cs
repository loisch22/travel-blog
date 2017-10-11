using Microsoft.EntityFrameworkCore;


namespace TravelBlog.Models
{
	public class TravelBlogDbContext : DbContext
	{
		public TravelBlogDbContext()
		{
		}

		public DbSet<Location> Locations { get; set; }

		public DbSet<Experience> Experiences { get; set; }

        public DbSet<People> People { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseMySql(@"Server=localhost;Port=8889;database=TravelBlog;uid=root;pwd=root;");
		}

		public TravelBlogDbContext(DbContextOptions<TravelBlogDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

            builder.Entity<ExperiencePeople>()
                .HasKey(t => new { t.ExperienceId, t.PeopleId });

            builder.Entity<ExperiencePeople>()
                .HasOne(pt => pt.Experiences)
                .WithMany(t => t.ExperiencePeople)
                .HasForeignKey(pt => pt.ExperienceId);

            builder.Entity<ExperiencePeople>()
                .HasOne(pt => pt.People)
                .WithMany(t => t.ExperiencePeople)
                .HasForeignKey(pt => pt.PeopleId);
        }
	}
}