using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Test2D_Retake.Models;

[Table("Match")]
public class Match
{
    [Key]
    public int MatchId { get; set; }
    public DateTime MatchDate { get; set; }
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }
    [Column(TypeName = "decimal")]
    [Precision(4, 2)]
    public decimal? BestRating { get; set; }
    
    [ForeignKey(nameof(Map))]
    public int MapId { get; set; }
    [ForeignKey(nameof(Tournament))]
    public int TournamentId { get; set; }

    public Map Maps { get; set; } = null!;
    public Tournament Tournaments { get; set; } = null!;
    
    public ICollection<PlayerMatch> PlayerMatches { get; set; } = null!;

}