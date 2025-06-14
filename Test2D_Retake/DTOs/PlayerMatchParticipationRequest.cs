namespace Test2D_Retake.DTOs;

public class PlayerMatchParticipationRequest
{
    public string firstName { get; set; } = null!;
    public string lastName { get; set; } = null!;
    public DateTime birthDate { get; set; }
    public List<MatchesRequestDto> matches { get; set; } = null!;
}

public class MatchesRequestDto
{
    public int matchId { get; set; }
    public int MVPs { get; set; }
    public decimal rating { get; set; }
}