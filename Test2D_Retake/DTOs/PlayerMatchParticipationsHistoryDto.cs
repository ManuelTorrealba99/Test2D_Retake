namespace Test2D_Retake.DTOs;

public class PlayerMatchParticipationsHistoryDto
{
    public int playerId { get; set; }
    public string firstName { get; set; } = null!;
    public string lastName { get; set; } = null!;
    public DateTime birthDate { get; set; }
    public List<MatchesDto> matches { get; set; } = null!;
}

public class MatchesDto
{
    public string tournament { get; set; } = null!;
    public string map { get; set; } = null!;
    public DateTime date { get; set; }
    public int MVPs { get; set; }
    public decimal rating { get; set; }
    public int team1Score { get; set; }
    public int team2Score { get; set; }
}