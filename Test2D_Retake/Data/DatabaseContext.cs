using Microsoft.EntityFrameworkCore;
using Test2D_Retake.Models;

namespace Retake_Test2D.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Map> Maps { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<PlayerMatch> PlayerMatches { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Map>().HasData(new List<Map>()
        {
            new Map() { MapId = 1, Name = "Infierno", Type = "CS2 Map" },
            new Map() { MapId = 2, Name = "Mirage", Type = "CS2 Map" },
            new Map() { MapId = 3, Name = "Palace", Type = "CS2 Map" },
        });
        
        modelBuilder.Entity<Tournament>().HasData(new List<Tournament>()
        {
            new Tournament() { TournamentId = 1, Name = "CS2 Summer Cup", StartDate = new DateTime(2025, 07, 01), EndDate = new DateTime(2025,07,10)},
            new Tournament() { TournamentId = 2, Name = "CS2 Winter Cup", StartDate = new DateTime(2026,01,05), EndDate = new DateTime(2026,01,20) },
        });
        
        modelBuilder.Entity<Player>().HasData(new List<Player>()
        {
            new Player() { PlayerId = 1, FirstName ="Alex", LastName = "Smith", BirthDate = new DateTime(2000,05,20)},
            new Player() { PlayerId = 2, FirstName ="Peter", LastName = "Lewis", BirthDate = new DateTime(2005,10,10) }
        });
        
        modelBuilder.Entity<Match>().HasData(new List<Match>()
        {
            new Match() { MatchId = 1, TournamentId = 1, MapId = 1, MatchDate = DateTime.Parse("2025-07-02"), Team1Score = 16, Team2Score = 12, BestRating = (decimal?)1.5},
            new Match() { MatchId = 2, TournamentId = 1, MapId = 2, MatchDate = DateTime.Parse("2025-07-03"), Team1Score = 10, Team2Score = 16, BestRating = (decimal?)1.3},
            new Match() { MatchId = 3, TournamentId = 1, MapId = 3, MatchDate = DateTime.Parse("2025-07-04"), Team1Score = 16, Team2Score = 8, BestRating = null},
        });
        
        modelBuilder.Entity<PlayerMatch>().HasData(new List<PlayerMatch>()
        {
            new PlayerMatch() { MatchId = 1, PlayerId = 1, MVPs = 3, Rating = (decimal)1.25},
            new PlayerMatch() { MatchId = 1, PlayerId = 2, MVPs = 1, Rating = (decimal)1.1},
            new PlayerMatch() { MatchId = 2, PlayerId = 1, MVPs = 2, Rating = (decimal)1.10},
            new PlayerMatch() { MatchId = 2, PlayerId = 2, MVPs = 4, Rating = (decimal)1.26},
            new PlayerMatch() { MatchId = 3, PlayerId = 1, MVPs = 4, Rating = (decimal)1.3},
            new PlayerMatch() { MatchId = 3, PlayerId = 2, MVPs = 1, Rating = (decimal)1.08},
        });
    }
}