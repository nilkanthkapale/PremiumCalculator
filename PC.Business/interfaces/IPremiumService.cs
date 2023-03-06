using PC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC.Business.interfaces
{
    public interface IPremiumService
    {
        /// <summary>
        /// Get the premium details
        /// </summary>
        /// <param name="person">Perosn for which premium to be calculted </param>
        /// <param name="occupationId">Occupation wise premium</param>
        /// <returns>Premium details</returns>
        PremiumDetails GetPremiumDetails(Person person, int occupationId);
    }
}
