
using Microsoft.EntityFrameworkCore;

namespace Mission10.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _context;

        // Constructor
        public EFBowlingRepository(BowlingLeagueContext temp) { 
            _context = temp;
        }

        // Method to retrieve all bowlers with their respective teams
        public IEnumerable<Bowler> GetAllBowlersWithTeams() 
    {
            // Query to join data and only get bowlers in team Marlins or Sharks
            var joinedData = from Bowler in _context.Bowlers
                             join Team in _context.Teams
                             on Bowler.TeamId equals Team.TeamId
                             where Team.TeamName == "Marlins" || Team.TeamName == "Sharks"

               select new Bowler
               {
                   BowlerId = Bowler.BowlerId,
                   BowlerFirstName = Bowler.BowlerFirstName,
                   BowlerLastName = Bowler.BowlerLastName,
                   BowlerMiddleInit = Bowler.BowlerMiddleInit,
                   BowlerAddress = Bowler.BowlerAddress,
                   BowlerCity = Bowler.BowlerCity,
                   BowlerState = Bowler.BowlerState,
                   BowlerZip = Bowler.BowlerZip,
                   BowlerPhoneNumber = Bowler.BowlerPhoneNumber,
                   Team = new Team
                   {
                       TeamName = Team.TeamName
                   }
               };
            return joinedData.ToList();
        }
    }
}
