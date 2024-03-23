namespace Mission10.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> GetAllBowlersWithTeams(); // To join the Bowlers and Teams table
    }


}
