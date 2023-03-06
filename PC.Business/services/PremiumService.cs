using PC.Business.interfaces;
using PC.Data.Data;
using PC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PC.Business.services
{
    public class PremiumService : IPremiumService
    {

        private readonly MasterData _masterData;

        public PremiumService(MasterData masterData)
        {
            _masterData = masterData;
        }


        public PremiumDetails GetPremiumDetails(Person person, int occupationId)
        {
            var premium = new PremiumDetails();

            try
            {
                var occupation = _masterData.Occupations.Single(x => x.Id == occupationId);
                var rating = _masterData.Ratings.Single(x => x.Id == occupation.RatingId);

                premium.DeathPremium = (person.SumInsured.Value * rating.Factor * person.Age.Value) / 1000 * 12;
                premium.TdpPremium = (person.SumInsured.Value * rating.Factor * person.Age.Value) / 1234;

                return premium;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
