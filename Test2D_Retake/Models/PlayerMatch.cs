using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test2D_Retake.Models;

[Table("PlayerMatch")]
[PrimaryKey(nameof(MatchId), nameof(PlayerId))]
public class PlayerMatch
{
    [ForeignKey(nameof(Match))]
    public int MatchId { get; set; }
    [ForeignKey(nameof(Player))]
    public int PlayerId { get; set; }
    public int MVPs { get; set; }
    [Column(TypeName = "decimal")]
    [Precision(4, 2)]
    public decimal Rating { get; set; }
    
    public Match Matches { get; set; } = null!;
    public Player Players { get; set; } = null!;
}