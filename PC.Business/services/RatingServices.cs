using PC.Business.interfaces;
using PC.Data.Data;
using PC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC.Business.services
{
    public class RatingServices : IRatingService
    {
        private readonly MasterData _masterData;

        public RatingServices(MasterData masterData)
        {
            _masterData = masterData;
        }


        public Rating GetRating(int id)
        {
            return _masterData.Ratings.Single(x => x.Id == id);
        }

        public List<Rating> GetRatings()
        {
            return _masterData.Ratings;
        }
    }
}
