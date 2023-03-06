
using PC.Data.Models;

namespace PC.Data.Data
{
    public class MasterData
    {
        public List<Rating> Ratings = new List<Rating>
        {

            new Rating (){ Id=1,  Name="Professional", Factor= 1 },
            new Rating (){ Id=2,  Name="White Collar", Factor= 1.25 },
            new Rating (){ Id=3,  Name="Light Manual", Factor= 1.5 },
            new Rating (){ Id=4,  Name="Heavy Manual", Factor= 1.75 }
        };

        public List<Occupation> Occupations = new List<Occupation> 
        {

            new Occupation(){ Id=1,  OccupationName = "Cleaner", RatingId = 3 },
            new Occupation(){ Id=2,  OccupationName = "Doctor", RatingId = 1 },
            new Occupation(){ Id=3,  OccupationName = "Author", RatingId = 2 },
            new Occupation(){ Id=4,  OccupationName = "Farmer", RatingId = 4 },
            new Occupation(){ Id=5,  OccupationName = "Mechanic", RatingId = 4},
            new Occupation(){ Id=6,  OccupationName = "Florist", RatingId = 3 },
        };
    }
}
