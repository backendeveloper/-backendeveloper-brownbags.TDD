using System.Collections.Generic;

namespace Brownbags
{
    public class JourneyService
    {
        private readonly IJourneyRepository _journeyRepository;

        public JourneyService(IJourneyRepository journeyRepository)
        {
            _journeyRepository = journeyRepository;
        }

        public List<Journey> List()
        {
            List<Journey> journeys = this._journeyRepository.List();

            if (journeys == null || journeys.Count == 0)
            {
                throw new ThereIsNoJourneyException();
            }

            return journeys;
        }
    }
}