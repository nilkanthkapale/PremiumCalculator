

using PC.Business.interfaces;
using PC.Data.Data;
using PC.Data.Models;

namespace PC.Business.services
{
    public class OccupationService : IOccupationService
    {
        private readonly MasterData _masterData;

        public OccupationService(MasterData masterData)
        {
            _masterData = masterData;
        }

        public Occupation GetOccupationById(int id)
        {
            return _masterData.Occupations.Single(x => x.Id == id);
        }

        public List<Occupation> GetOccupations()
        {
            return _masterData.Occupations;
        }
    }
}
