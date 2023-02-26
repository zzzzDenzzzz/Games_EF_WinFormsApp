using Games_EF_WinFormsApp.Entities;
using Games_EF_WinFormsApp.EntityMappings;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Games_EF_WinFormsApp.Contexts
{
    public partial class GameContext : DbContext
    {
        public GameContext()
        {
        }

        public GameContext(DbContextOptions<GameContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Game> Games { get; set; }

        public virtual DbSet<CreatorGame> CreatorGames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(ConfigurationManager.ConnectionStrings["connectionHome"].ConnectionString)
                .UseLazyLoadingProxies();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GameEntityMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CreatorGameEntityMap).Assembly);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
