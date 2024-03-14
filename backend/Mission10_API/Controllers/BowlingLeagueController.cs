using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_API.Data;

namespace Mission10_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingLeagueController(IBowlingRepository temp) {
            _bowlingRepository = temp;
        }

        //get bowler infomration
        [HttpGet]
        public IEnumerable<CombinedData> Get()
        {
            var joinedData = _bowlingRepository.GetAllBowlingInfo();
            return joinedData;
        }
        
    }
}
