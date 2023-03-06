
using PC.Data.Models;

namespace PC.Business.interfaces
{
    public interface IRatingService
    {
        /// <summary>
        /// List of rating 
        /// </summary>
        /// <returns>List of rating</returns>
        List<Rating> GetRatings();

        /// <summary>
        /// Get the single rating for selcted id
        /// </summary>
        /// <param name="id">id of the rating</param>
        /// <returns>Single Rating, throw exception if not found</returns>
        Rating GetRating(int id);
    }
}
