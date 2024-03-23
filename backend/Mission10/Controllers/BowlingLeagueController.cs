using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10.Models;
using SQLitePCL;

namespace Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingLeagueRepo;

        public BowlingLeagueController(IBowlingRepository temp)
        {
            _bowlingLeagueRepo = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            // Getting Bowler data with team names
            var bowlerData = _bowlingLeagueRepo.GetAllBowlersWithTeams();
            return bowlerData;
        }
    }
}
