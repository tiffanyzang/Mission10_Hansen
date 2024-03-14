
using Microsoft.EntityFrameworkCore;
using Mission10_API.Data;

namespace Mission10_API.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext;
        public EFBowlingRepository(BowlingLeagueContext temp) 
        { 
            _bowlingContext = temp;
        }

        public IEnumerable<CombinedData> GetAllBowlingInfo()
        {
            var query = from bowler in _bowlingContext.Bowlers
                        join team in _bowlingContext.Teams on bowler.TeamId equals team.TeamId
                        where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                        select new CombinedData
                        {
                            BowlerName = bowler.BowlerFirstName + " " +
                                             (string.IsNullOrEmpty(bowler.BowlerMiddleInit) ? "" : bowler.BowlerMiddleInit + " ") +
                                             bowler.BowlerLastName,
                            TeamName = team.TeamName,
                            BowlerAddress = bowler.BowlerAddress,
                            BowlerCity = bowler.BowlerCity,
                            BowlerState = bowler.BowlerState,
                            BowlerZip = bowler.BowlerZip,
                            BowlerPhoneNumber = bowler.BowlerPhoneNumber
                        };
            return query.ToArray();

        }
    }
}
