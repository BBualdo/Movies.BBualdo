using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class MovieDbContext(DbContextOptions<MovieDbContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.SeedMovies();
    }
}

public static class ModelBuilderExtensions
{
    public static void SeedMovies(this ModelBuilder modelBuilder)
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie {Id = 1, Title = "Toy Story 2", Genre = "Animation", ReleaseDate = new DateOnly(1999, 11, 13), Price = 24.99m},
            new Movie {Id = 2, Title = "The Matrix", Genre = "Science Fiction", ReleaseDate = new DateOnly(1999, 3, 31), Price = 19.99m},
            new Movie {Id = 3, Title = "Inception", Genre = "Action", ReleaseDate = new DateOnly(2010, 7, 16), Price = 29.99m},
            new Movie {Id = 4, Title = "The Shawshank Redemption", Genre = "Drama", ReleaseDate = new DateOnly(1994, 9, 23), Price = 14.99m},
            new Movie {Id = 5, Title = "Pulp Fiction", Genre = "Crime", ReleaseDate = new DateOnly(1994, 10, 14), Price = 18.99m},
            new Movie {Id = 6, Title = "The Dark Knight", Genre = "Action", ReleaseDate = new DateOnly(2008, 7, 18), Price = 24.99m},
            new Movie {Id = 7, Title = "Forrest Gump", Genre = "Drama", ReleaseDate = new DateOnly(1994, 7, 6), Price = 17.99m},
            new Movie {Id = 8, Title = "The Lion King", Genre = "Animation", ReleaseDate = new DateOnly(1994, 6, 24), Price = 19.99m},
            new Movie {Id = 9, Title = "Gladiator", Genre = "Action", ReleaseDate = new DateOnly(2000, 5, 5), Price = 21.99m},
            new Movie {Id = 10, Title = "Titanic", Genre = "Romance", ReleaseDate = new DateOnly(1997, 12, 19), Price = 22.99m}
        };
        modelBuilder.Entity<Movie>().HasData(movies);
    }
}