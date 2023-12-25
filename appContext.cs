using eve_api.tables;
using Microsoft.EntityFrameworkCore;

namespace eve_api
{
    
    public class appContext:DbContext
    {
        public appContext(DbContextOptions<appContext> options) : base(options)
        {

        }
        public DbSet<Post_Table> post_Tables => Set<Post_Table>();

        public DbSet<User_Table> user_Tables => Set<User_Table>();

        public DbSet<Partners_Table> partners_Tables => Set<Partners_Table>();

        public DbSet<News_Table> news_Tables => Set<News_Table>();
    }
}
