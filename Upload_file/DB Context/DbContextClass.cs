using Microsoft.EntityFrameworkCore;
namespace Upload_file.DB_Context
{
    public class DbContextClass:DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring
            (DbContextOptionsBuilder options)
        {
            options.UseSqlServer
                (Configuration.
                GetConnectionString("DefaultConnection"));
        }
        public DbSet<FileDetails> FileDetails 
        {  get; set; }
    }
}