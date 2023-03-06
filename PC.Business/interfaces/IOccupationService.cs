
using PC.Data.Models;

namespace PC.Business.interfaces
{
    public interface IOccupationService
    {
        /// <summary>
        /// List of occupation
        /// </summary>
        /// <returns>List of occupation</returns>
        List<Occupation> GetOccupations();

        /// <summary>
        /// Single occupation
        /// </summary>
        /// <param name="id">id of the occupation</param>
        /// <returns>single occupation when found else throw an error</returns>
        Occupation GetOccupationById(int id);
    }
}
